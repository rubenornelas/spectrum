using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;
using System.IO;

namespace CTPro
{
    class CamCalibration
    {
        private static Point point1, point2, point3, point4;
        private Mat src;
        private int thePoint;
        private bool rectangleCreated;
        private static string path;
        private static int theWidth, theHeight, frameWidth, frameHeight;

        public CamCalibration()
        {
            thePoint = 1;
        }

        public static void SetFrameSize(int width, int height)
        {
            frameWidth = width;
            frameHeight = height;
        }

        public static int[] GetFrameArray()
        {
            int[] array = new int[2] { frameWidth, frameHeight };
            return array;
        }

        public static void SetPoints(Point filedPoint, int point)
        {
            switch (point)
            {
                case 0:
                    point1 = filedPoint;
                    break;
                case 1:
                    point2 = filedPoint;
                    break;
                case 2:
                    point3 = filedPoint;
                    break;
                case 3:
                    point4 = filedPoint;
                    break;
            }
        }

        public void CropLoop(VideoCapture cam_test, Window calWindow)
        {
            src = cam_test.RetrieveMat(); //Real image of the camera
            Cv2.Resize(src, src, new Size(frameWidth, frameHeight), 1, 1, InterpolationFlags.Cubic);

            if (point1.X != 0)
            {
                Cv2.Circle(src, point1, 2, new Scalar(250, 0, 0), 5, LineTypes.AntiAlias);
            }
            if (point2.X != 0)
            {
                Cv2.Circle(src, point2, 2, new Scalar(250, 0, 0), 5, LineTypes.AntiAlias);
                Cv2.Line(src, point1, point2, new Scalar(250, 0, 0), 2, LineTypes.AntiAlias);
            }
            if (point3.X != 0)
            {
                Cv2.Circle(src, point3, 2, new Scalar(250, 0, 0), 5, LineTypes.AntiAlias);
                Cv2.Line(src, point2, point3, new Scalar(250, 0, 0), 2, LineTypes.AntiAlias);
            }
            if (point4.X != 0)
            {
                Cv2.Circle(src, point4, 2, new Scalar(250, 0, 0), 5, LineTypes.AntiAlias);
                Cv2.Line(src, point3, point4, new Scalar(250, 0, 0), 2, LineTypes.AntiAlias);
                Cv2.Line(src, point4, point1, new Scalar(250, 0, 0), 2, LineTypes.AntiAlias);
                rectangleCreated = true;
            }

            Cv2.ImShow(calWindow.Name, src);

            Cv2.WaitKey(1);
            src.Dispose();
        }

        public static void SetPath(string fileName)
        {
            path = Path.Combine(Environment.CurrentDirectory, @"CamFiles\", fileName);
        }

        public static string GetPath()
        {
            return path;
        }

        public void SaveFile(string[] s)
        {
            File.WriteAllLines(path, s);

            using (StreamWriter sw = File.CreateText(path + "-" + frameWidth + "x" + frameHeight + ".txt"))
            {
                foreach (string sr in s)
                {
                    sw.WriteLine(sr);
                }
            }
        }

        public bool RectangleCreated()
        {
            return rectangleCreated;
        }

        public static void SetResolution(int width, int height)
        {
            theWidth = width;
            theHeight = height;
        }

        public static int[] GetResolution()
        {
            int[] res = new int[2] { theWidth, theHeight };
            return res;
        }

        public void ResetPoints()
        {
            point1 = new Point(0, 0);
            point2 = new Point(0, 0);
            point3 = new Point(0, 0);
            point4 = new Point(0, 0);
        }

        public static Point GetPoint1()
        {
            return point1;
        }

        public static Point2f[] GetROIPoints()
        {
            Point2f[] pts = new Point2f[]
            {
                point1, point2, point3, point4
            };

            return pts;
        }

        public static Point2f[] GetDf32()
        {
            Point2f[] df32 = new Point2f[]
            {
                new Point2f(0,0),
                new Point2f(GetMaxWidth() - 1, 0),
                new Point2f(GetMaxWidth() -1, GetMaxHeight() - 1),
                new Point2f(0, GetMaxHeight() - 1)
            };

            return df32;
        }

        public static int GetMaxWidth()
        {
            int widthA = point2.X - point1.X;
            int widthB = point3.X - point4.X;

            return Math.Max(widthA, widthB);
        }

        public static int GetMaxHeight()
        {
            int heightA = point4.Y - point1.Y;
            int heightB = point3.Y - point2.Y;

            return Math.Max(heightA, heightB);
        }

        public void Click(MouseEvent me, int x, int y, MouseEvent flags)
        {
            if (me == MouseEvent.LButtonDown)
            {
                switch (thePoint)
                {
                    case 1:
                        point1 = new Point(x, y);
                        thePoint = 2;
                        break;

                    case 2:
                        point2 = new Point(x, y);
                        thePoint = 3;
                        break;

                    case 3:
                        point3 = new Point(x, y);
                        thePoint = 4;
                        break;

                    case 4:
                        point4 = new Point(x, y);
                        thePoint = 1;
                        break;
                }
            }
        }
    }
}
