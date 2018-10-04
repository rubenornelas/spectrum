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
        private Mat src = new Mat(); //Source image (empty)
        private Mat dstPreview = new Mat(); //Output image (empty)
        private CvBlobs blobDetection = new CvBlobs();
        private static bool realView, blobView, orientation;

        /// <summary>
        /// List of arrays in HSV from calibration file.
        /// Hue=0; Sat_min=1; Sat_max=2; Val_min=3; Val_max=4.
        /// </summary>
        private static List<int[]> hsv;

        // UDP info
        private static UdpClient udpClient = new UdpClient();
        private static string udpDatagram_1 = "";
        private static string udpDatagram_2 = "";
        private static string udpDatagram_3 = "";
        private static string udpDatagram_4 = "";
        private static string udpDatagram_5 = "";
        private static string deviceName = "ctpro";
        private static long data_id = DateTime.Now.Ticks;

        public static string colorCalibrationPath;

        public static string IP_udp { get; set; }

        public static int Port_udp { get; set; }

        public static int MorphValue { get; set; }

        public static int MinBlobArea { get; set; }

        public static int MaxBlobArea { get; set; }

        public static string ColorFileName { get; set; }

        public static string CameraFileName { get; set; }

        public Dictionary<string, Scalar> colorLabels;

        public Main()
        {
            colorLabels = new Dictionary<string, Scalar>();
            colorLabels.Add("red", new Scalar(255, 0, 0));
            colorLabels.Add("green", new Scalar(0, 255, 0));
            colorLabels.Add("blue", new Scalar(0, 0, 255));

            //Cv2.CvtColor(colorLabels["red"], outPut, ColorConversionCodes.BGR2Lab);
            
        }

        /// <summary>
        /// Sets <see cref="realView"/> to show or unshow camera window.
        /// May improve preformance.
        /// </summary>
        /// <param name="boolean"></param>
        public static void SetRealView(bool boolean)
        {
            realView = boolean;
        }

        /// <summary>
        /// Sets <see cref="blobView"/> to show or unshow blob window.
        /// May improve preformance.
        /// </summary>
        /// <param name="boolean"></param>
        public static void SetBlobView(bool boolean)
        {
            blobView = boolean;
        }

        /// <summary>
        /// Builds the path to file inside ColorFiles folder.
        /// </summary>
        /// <param name="fileName">Name of the file picked.</param>
        public static void ColorCalibrationPath(string fileName)
        {
            colorCalibrationPath = Path.Combine(Environment.CurrentDirectory, @"ColourFiles\" + fileName);
        }

        /// <summary>
        /// In case of setting to false it keeps image orientation otherwise vertically flips image.
        /// </summary>
        /// <param name="newOrientation"></param>
        public static void SetOrientation(bool boolean)
        {
            orientation = boolean;
        }

        /// <summary>
        /// Tracking function.
        /// Applies camera correction and then starts <see cref="Renderer(Mat)"/> function.
        /// </summary>
        /// <param name="cam_test"></param>
        /// <param name="srcWindow"></param>
        /// <param name="dstWindow"></param>
        public void SpectrumTrack(VideoCapture cam_test, Window srcWindow, Window dstWindow)
        {
            src = cam_test.RetrieveMat(); // Real image of the camera
            Cv2.Resize(src, src, new Size(CamCalibration.GetFrameArray()[0], CamCalibration.GetFrameArray()[1]), 1, 1, InterpolationFlags.Cubic);

            Mat lambda = Cv2.GetPerspectiveTransform(CamCalibration.GetROIPoints(), CamCalibration.GetDf32());
            Cv2.WarpPerspective(src, src, lambda, new Size(CamCalibration.GetMaxWidth(), CamCalibration.GetMaxHeight()));

            dstPreview = Renderer(src);

            // Show processed images in the right windows
            if (!realView)
            {
                Cv2.ImShow(srcWindow.Name, src);
                src.Dispose();
            }
            if (!blobView)
            {
                Cv2.ImShow(dstWindow.Name, dstPreview);
                dstPreview.Dispose();
            }
            Cv2.WaitKey(1);
        }

        /// <summary>
        /// Takes blobs information based on colors in <see cref="hsv"/> list and then sends the info through UDP.
        /// </summary>
        /// <param name="sourceImage">Image in Mat format.</param>
        /// <returns>Image in Mat format.</returns>
        private Mat Renderer(Mat sourceImage)
        {
            Mat dstNoisy = src;
            Mat dstClear = new Mat();
            Mat dst = new Mat();
            Mat element = Cv2.GetStructuringElement(MorphShapes.Rect, new Size(2 * MorphValue + 1, 2 * MorphValue + 1));

            Cv2.Blur(dstNoisy, dstClear, new Size(9, 9));

            Cv2.CvtColor(dstClear, dst, ColorConversionCodes.BGR2HSV); // Convert BGR to HSV.

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
                    
                    // Morphologic transformation to close the gaps inside the blob.
                    Cv2.MorphologyEx(src: dstThreshed,
                        dst: dstThreshed,
                        op: MorphTypes.Close,
                        element: element
                        );

                    blobDetection.Label(dstThreshed);
                    blobDetection.FilterByArea(MinBlobArea, MaxBlobArea);
                    blobDetection.RenderBlobs(dstThreshed, src);
                    CircleSegment[] circles = Cv2.HoughCircles(dstThreshed, HoughMethods.Gradient, 1, dstThreshed.Rows / 8);

                    // Creates all udp datagrams----------------------------------------------------
                    if (blobDetection.Count != 0)
                    {
                        for (int i = 0; i < blobDetection.Count; i++)
                        {
                            int processKey = blobDetection.ElementAt(i).Key;
                            udpDatagram_1 = "[$]tracking|id=" + data_id + "|label=" + blobCount + "|[$$]" + deviceName + ",[$$$]mesh,sample,";
                            for (int j = 0; j < blobDetection[processKey].Contour.ConvertToPolygon().Simplify(1).Count; j++)
                            {
                                if (orientation)
                                {
                                    udpDatagram_1 += Math.Round((float)blobDetection[processKey].Contour.ConvertToPolygon().Simplify(1).ElementAt(j).X / dst.Cols, 4).ToString().Replace(',', '.');
                                    udpDatagram_1 += "," + (1 - Math.Round((float)blobDetection[processKey].Contour.ConvertToPolygon().Simplify(1).ElementAt(j).Y / dst.Rows, 4)).ToString().Replace(',', '.');
                                    udpDatagram_1 += ",";
                                }
                                else
                                {
                                    udpDatagram_1 += (1 - Math.Round((float)blobDetection[processKey].Contour.ConvertToPolygon().Simplify(1).ElementAt(j).X / dst.Cols, 4)).ToString().Replace(',', '.');
                                    udpDatagram_1 += "," + Math.Round((float)blobDetection[processKey].Contour.ConvertToPolygon().Simplify(1).ElementAt(j).Y / dst.Rows, 4).ToString().Replace(',', '.');
                                    udpDatagram_1 += ",";
                                }
                            }
                            udpDatagram_1 += ";";
                            udpDatagram_2 = "[$]tracking|id=" + data_id + "|label=" + blobCount + "|[$$]" + deviceName + ",[$$$]area,";
                            udpDatagram_2 += "value," + blobDetection[processKey].Contour.ConvertToPolygon().Simplify(1).Area().ToString().Replace(',', '.') + ";";
                            udpDatagram_3 = "[$]tracking|id=" + data_id + "|label=" + blobCount + "|[$$]" + deviceName + ",[$$$]place,";
                            if (orientation)
                            {
                                udpDatagram_3 += "position," + (Math.Round(blobDetection[processKey].Centroid.X / dst.Cols, 3)).ToString().Replace(',', '.') + "," + (Math.Round(1 - (blobDetection[processKey].Centroid.Y / dst.Rows), 3)).ToString().Replace(',', '.') + ";";
                            }
                            else
                            {
                                udpDatagram_3 += "position," + (Math.Round(1 - (blobDetection[processKey].Centroid.X / dst.Cols), 3)).ToString().Replace(',', '.') + "," + (Math.Round(blobDetection[processKey].Centroid.Y / dst.Rows, 3)).ToString().Replace(',', '.') + ";";
                            }
                            udpDatagram_4 = "[$]tracking|id=" + data_id + "|label=" + blobCount + "|[$$]" + deviceName + ",[$$$]color,";
                            udpDatagram_4 += "hsv," + scal[0] + "-" + (scal[1] + scal[2]) / 2 + "-" + (scal[3] + scal[4]) / 2 + ";";
                            
                            //Geometry
                            udpDatagram_5 = "[$]tracking|id=" + data_id + "|label=" + blobCount + "|[$$]" + deviceName + ",[$$$]form,geometry,";
                            CvContourPolygon poly = blobDetection[processKey].Contour.ConvertToPolygon();
                            double epsilon = 0.04 * Cv2.ArcLength(poly, true);
                            Point[] counterResult = Cv2.ApproxPolyDP(poly, epsilon, closed: true);
                            int contourSimple_counter = counterResult.Length;
                            string geometry = "";
                            switch (contourSimple_counter)
                            {
                                case 3:
                                    geometry = "triangle";
                                    break;
                                case 4:
                                    Rect rect = Cv2.BoundingRect(poly);
                                    float aspectRatio = rect.X / rect.Y;
                                    if (aspectRatio >= 0.95 && aspectRatio <= 1.05)
                                        geometry = "square";
                                    else
                                        geometry = "rectangle";
                                    break;
                                default:
                                    geometry = "unidentified" + contourSimple_counter;
                                    break;
                            }
                            udpDatagram_5 += geometry + ";";
                            Cv2.PutText(src, geometry, blobDetection[processKey].Centroid, HersheyFonts.HersheySimplex, 0.5, new Scalar(0, 255, 0), 2);
                            Cv2.PutText(src, "[" + scal[0] + ", " + ((scal[1] + scal[2])/2) + ", " + ((scal[3] + scal[4])/2) + "]" , new Point(blobDetection[processKey].Centroid.X, blobDetection[processKey].Centroid.Y + 20), HersheyFonts.HersheySimplex, 0.45, new Scalar(0, 255, 0), 2);
                            // UDP sender---------------------------------------------------------------------
                            try
                            {
                                byte[] sendBytes_1 = Encoding.ASCII.GetBytes(udpDatagram_1);
                                byte[] sendBytes_2 = Encoding.ASCII.GetBytes(udpDatagram_2);
                                byte[] sendBytes_3 = Encoding.ASCII.GetBytes(udpDatagram_3);
                                byte[] sendBytes_4 = Encoding.ASCII.GetBytes(udpDatagram_4);
                                byte[] sendBytes_5 = Encoding.ASCII.GetBytes(udpDatagram_5);
                                udpClient.Send(sendBytes_1, sendBytes_1.Length, IP_udp, Port_udp);
                                udpClient.Send(sendBytes_2, sendBytes_2.Length, IP_udp, Port_udp);
                                udpClient.Send(sendBytes_3, sendBytes_3.Length, IP_udp, Port_udp);
                                udpClient.Send(sendBytes_4, sendBytes_4.Length, IP_udp, Port_udp);
                                udpClient.Send(sendBytes_5, sendBytes_5.Length, IP_udp, Port_udp);
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

            // Same morphologic transformation but this time for the output image.
            Cv2.MorphologyEx(src: dstPreview,
                dst: dstPreview,
                op: MorphTypes.Close,
                element: element
                );

            return dstPreview;
        }

        /// <summary>
        /// Populate <see cref="hsv"/> list with values from file.
        /// </summary>
        /// <param name="calibrationPath"></param>
        public static void FillColorList(string calibrationPath)
        {
            List<string> listColours = new List<string>();
            hsv = new List<int[]>();

            using (StreamReader sr = File.OpenText(calibrationPath))
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
    }
}
