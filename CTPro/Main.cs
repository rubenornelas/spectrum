using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;
using OpenCvSharp.Blob;
using System.Net.Sockets;
using System.IO;

namespace CTPro
{
    class Main
    {
        private int elementValue = 7;
        private Mat src = new Mat(); //Source image (empty)
        private Mat dstPreview = new Mat(); //Output image (empty)
        private CvBlobs blobDetection = new CvBlobs();
        private static bool real, blob, orientation;
        private static string calPath;
        private static List<int[]> hsv;

        // UDP
        private static UdpClient udpClient = new UdpClient();
        private static string udpDatagram_1 = "";
        private static string udpDatagram_2 = "";
        private static string udpDatagram_3 = "";
        private static string udpDatagram_4 = "";
        private static string deviceName = "ctpro";
        private static long id = DateTime.Now.Ticks;

        //private static CvTrackbar trackbarE = new CvTrackbar("Morph Value", dstWindowName, 3, 21, OnNewTrackbarValueE, null);
        public static void SetReal(bool realImage)
        {
            real = realImage;
        }
        
        public static void SetBlob(bool blobImage)
        {
            blob = blobImage;
        }

        public static void SetCalPath(string fileName)
        {
            calPath = Path.Combine(Environment.CurrentDirectory, @"ColourFiles\" + fileName);
        }

        public static void SetOrientation(bool newOrientation)
        {
            orientation = newOrientation;
        }

        public void MainLoop(VideoCapture cam_test, Window srcWindow, Window dstWindow)
        {
            src = cam_test.RetrieveMat(); // Real image of the camera
            Cv2.Resize(src, src, new Size(CamCalibration.GetFrameArray()[0], CamCalibration.GetFrameArray()[1]), 1, 1, InterpolationFlags.Cubic);
            bool theReal = real;
            bool theBlob = blob;

            Mat lambda = Cv2.GetPerspectiveTransform(CamCalibration.GetROIPoints(), CamCalibration.GetDf32());
            Cv2.WarpPerspective(src, src, lambda, new Size(CamCalibration.GetMaxWidth(), CamCalibration.GetMaxHeight()));

            dstPreview = Renderer(src);

            // Show processed images in the right windows
            if (!theReal)
            {
                Cv2.ImShow(srcWindow.Name, src);
                src.Dispose();
            }
            if (!theBlob)
            {
                Cv2.ImShow(dstWindow.Name, dstPreview);
                dstPreview.Dispose();
            }
            Cv2.WaitKey(1);
        }

        private Mat Renderer(Mat src)
        {
            Mat dstNoisy = src;
            Mat dstClear = new Mat();
            Mat dst = new Mat();
            Mat element = Cv2.GetStructuringElement(MorphShapes.Rect, new Size(2 * elementValue + 1, 2 * elementValue + 1));

            Cv2.MedianBlur(dstNoisy, dstClear, 3); //Remove noise ---> int must be odd(1, 3, 5, 7 ...)
            Cv2.Blur(dstClear, dstClear, new Size(3, 3));

            Cv2.CvtColor(dstClear, dst, ColorConversionCodes.BGR2HSV); //convert BGR to HSV

            Mat dstThreshed = new Mat();
            Mat dstPreview = new Mat();

            if (hsv.Count > 0)
            {
                int blobCount = 1;
                bool theFirst = true;

                foreach (int[] scal in hsv)
                {
                    if (theFirst)
                    {
                        Cv2.InRange(dst, new Scalar(scal[0] - 10, scal[1], scal[3]), new Scalar(scal[0] + 10, scal[2], scal[4]), dstPreview);
                        theFirst = false;
                    }
                    else
                    {
                        Mat dstPreview2 = new Mat();
                        Cv2.InRange(dst, new Scalar(scal[0] - 10, scal[1], scal[3]), new Scalar(scal[0] + 10, scal[2], scal[4]), dstPreview2);
                        Cv2.AddWeighted(dstThreshed, 1.0, dstPreview2, 1.0, 0.0, dstPreview);
                    }
                    Cv2.InRange(dst, new Scalar(scal[0] - 10, scal[1], scal[3]), new Scalar(scal[0] + 10, scal[2], scal[4]), dstThreshed);
                    // Morphology transformation to close the gaps inside the blob
                    Cv2.MorphologyEx(src: dstThreshed,
                        dst: dstThreshed,
                        op: MorphTypes.Close,
                        element: element
                        );

                    blobDetection.Label(dstThreshed);
                    blobDetection.FilterByArea(5, 500000);
                    blobDetection.RenderBlobs(dstThreshed, src);

                    if (blobDetection.Count != 0)
                    {
                        for (int i = 0; i < blobDetection.Count; i++)
                        {
                            udpDatagram_1 = "[$]tracking|id=" + id + "|label=" + blobCount + "|[$$]" + deviceName + ",[$$$]mesh,sample,";
                            for (int j = 0; j < blobDetection.ElementAt<KeyValuePair<int, CvBlob>>(i).Value.Contour.ConvertToPolygon().Simplify(1).Count; j++)
                            {
                                if (orientation)
                                {
                                    udpDatagram_1 += Math.Round((float)blobDetection.ElementAt<KeyValuePair<int, CvBlob>>(i).Value.Contour.ConvertToPolygon().Simplify(1).ElementAt<Point>(j).X / dst.Cols, 4).ToString().Replace(',', '.');
                                    udpDatagram_1 += "," + (1 - Math.Round((float)blobDetection.ElementAt<KeyValuePair<int, CvBlob>>(i).Value.Contour.ConvertToPolygon().Simplify(1).ElementAt<Point>(j).Y / dst.Rows, 4)).ToString().Replace(',', '.');
                                    udpDatagram_1 += ",";
                                }
                                else
                                {
                                    udpDatagram_1 += (1 - Math.Round((float)blobDetection.ElementAt<KeyValuePair<int, CvBlob>>(i).Value.Contour.ConvertToPolygon().Simplify(1).ElementAt<Point>(j).X / dst.Cols, 4)).ToString().Replace(',', '.');
                                    udpDatagram_1 += "," + Math.Round((float)blobDetection.ElementAt<KeyValuePair<int, CvBlob>>(i).Value.Contour.ConvertToPolygon().Simplify(1).ElementAt<Point>(j).Y / dst.Rows, 4).ToString().Replace(',', '.');
                                    udpDatagram_1 += ",";
                                }
                            }
                            udpDatagram_1 += ";";
                            udpDatagram_2 = "[$]tracking|id=" + id + "|label=" + blobCount + "|[$$]" + deviceName + ",[$$$]area,";
                            udpDatagram_2 += "value," + blobDetection.ElementAt(i).Value.Contour.ConvertToPolygon().Simplify(1).Area().ToString().Replace(',', '.') + ";";
                            int processKey = blobDetection.ElementAt<KeyValuePair<int, CvBlob>>(i).Key;
                            udpDatagram_3 = "[$]tracking|id=" + id + "|label=" + blobCount + "|[$$]" + deviceName + ",[$$$]place,";
                            if (orientation)
                            {
                                udpDatagram_3 += "position," + (Math.Round(blobDetection[processKey].Centroid.X / dst.Cols, 3)).ToString().Replace(',', '.') + "," + (Math.Round(1 - (blobDetection[processKey].Centroid.Y / dst.Rows), 3)).ToString().Replace(',', '.') + ";";
                            }
                            else
                            {
                                udpDatagram_3 += "position," + (Math.Round(1 - (blobDetection[processKey].Centroid.X / dst.Cols), 3)).ToString().Replace(',', '.') + "," + (Math.Round(blobDetection[processKey].Centroid.Y / dst.Rows, 3)).ToString().Replace(',', '.') + ";";
                            }
                            udpDatagram_4 = "[$]tracking|id=" + id + "|label=" + blobCount + "|[$$]" + deviceName + ",[$$$]color,";
                            udpDatagram_4 += "string," + scal[0] + "-" + (scal[1] + scal[2]) / 2 + "-" + (scal[3] + scal[4]) / 2 + ";";

                            // UDP sender---------------------------------------------------------------------
                            try
                            {
                                Byte[] sendBytes_1 = Encoding.ASCII.GetBytes(udpDatagram_1);
                                Byte[] sendBytes_2 = Encoding.ASCII.GetBytes(udpDatagram_2);
                                Byte[] sendBytes_3 = Encoding.ASCII.GetBytes(udpDatagram_3);
                                Byte[] sendBytes_4 = Encoding.ASCII.GetBytes(udpDatagram_4);
                                udpClient.Send(sendBytes_1, sendBytes_1.Length, "127.0.0.1", 1202);
                                udpClient.Send(sendBytes_2, sendBytes_2.Length, "127.0.0.1", 1202);
                                udpClient.Send(sendBytes_3, sendBytes_3.Length, "127.0.0.1", 1202);
                                udpClient.Send(sendBytes_4, sendBytes_4.Length, "127.0.0.1", 1202);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.ToString());
                            }
                            udpDatagram_1 = "";
                            udpDatagram_2 = "";
                            udpDatagram_3 = "";
                            udpDatagram_4 = "";
                            blobCount++;
                        }
                    }
                }
                blobCount = 1;
            }
            Cv2.MorphologyEx(src: dstPreview,
                dst: dstPreview,
                op: MorphTypes.Close,
                element: element
                );
            return dstPreview;
        }

        public static void FillColorList()
        {
            List<string> listColours = new List<string>();
            hsv = new List<int[]>();

            using (StreamReader sr = File.OpenText(calPath))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    listColours.Add(s);
                }
            }
            string[] colours = listColours.ToArray();

            foreach (string c in colours)
            {
                int[] arr = new int[5];

                string[] firstDivision = c.Split('|'); // [0] -> H:X => [1] -> Sm:X => [2] -> SM:X => [1] -> Vm:X => [2] -> VM:X

                for (int i = 0; i < firstDivision.Length; i++)
                {
                    string[] value = firstDivision[i].Split(':'); // [0] -> H/S/V => [1] -> X
                    int ele = int.Parse(value[1]);
                    arr[i] = ele;
                }
                hsv.Add(arr);
            }
        }

        public void OnNewTrackbarValueE(int value, object sender)
        {
            elementValue = value;
        }
    }
}
