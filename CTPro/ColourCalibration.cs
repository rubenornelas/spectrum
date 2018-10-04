using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;
using System.IO;

namespace CTPro
{
    class ColourCalibration
    {
        private Point colourPoint;
        private bool blobView, colourPicked;
        private int coloursAdded, elementSm, elementSM, elementVm, elementVM;
        private string path;
        private static string thePath;
        private List<string> coloursToBeSaved;
        private Mat HSV, RGB, src;
        private Vec3b hsv, rgb;
        private Scalar newColor_hsv, newColor_rgb;

        public bool AddNewColour { get; set; }
        public int Hue { get; set; }

        public ColourCalibration()
        {
            coloursToBeSaved = new List<string>();
            newColor_hsv = new Scalar(0, 0, 0);
            Hue = -1;
        }

        public void ColourLoop(VideoCapture cam_test, Window colourWindow)
        {
            src = cam_test.RetrieveMat();
            Cv2.Resize(src, src, new Size(CamCalibration.GetFrameArray()[0], CamCalibration.GetFrameArray()[1]), 1, 1, InterpolationFlags.Cubic);

            if (colourPicked)
            {
                HSV = new Mat();
                RGB = new Mat(src, new Rect(colourPoint.X, colourPoint.Y, 1, 1));

                Cv2.CvtColor(RGB, HSV, ColorConversionCodes.BGR2HSV);
                hsv = HSV.At<Vec3b>(0, 0);
                newColor_hsv = new Scalar(hsv[0], hsv[1], hsv[2]);
                Hue = hsv[0];

                rgb = RGB.At<Vec3b>(0, 0);
                newColor_rgb = new Scalar(rgb[0], rgb[1], rgb[2]);

                colourPicked = false;
                AddNewColour = true;

                HSV.Dispose();
                RGB.Dispose();
            }

            if (blobView)
            {
                Cv2.Blur(src, src, new Size(3, 3));
                Cv2.CvtColor(src, src, ColorConversionCodes.BGR2HSV);
                Cv2.InRange(src, new Scalar(hsv[0] - 10, elementSm, elementVm), new Scalar(hsv[0] + 10, elementSM, elementVM), src);
            }

            Cv2.ImShow(colourWindow.Name, src);

            Cv2.WaitKey(1);

            src.Dispose();
        }

        public void AddColour()
        {
            coloursToBeSaved.Add("H:" + hsv[0] + "|Sm:" + elementSm + "|SM:"
                            + elementSM + "|Vm:" + elementVm + "|VM:" + elementVM);
            coloursAdded++;
        }

        public int GetColoursAdded()
        {
            return coloursAdded;
        }

        public List<string> GetColoursToBeSaved()
        {
            return coloursToBeSaved;
        }

        public void SetPath(string nameFile)
        {
            path = Path.Combine(Environment.CurrentDirectory, @"ColourFiles\", nameFile + ".txt");
            thePath = path;
        }

        public void SetBlobView(bool result)
        {
            blobView = result;
        }

        public System.Drawing.Color GetNewColor()
        {
            System.Drawing.Color outColor = new System.Drawing.Color();
            outColor = System.Drawing.Color.FromArgb(int.Parse(newColor_rgb.Val2.ToString()),
                int.Parse(newColor_rgb.Val1.ToString()), int.Parse(newColor_rgb.Val0.ToString()));
            return outColor;
        }

        public void SaveFile()
        {
            string[] s = coloursToBeSaved.ToArray();
            File.WriteAllLines(path, s);

            using (StreamWriter sw = File.CreateText(path))
            {
                foreach (string sr in s)
                {
                    sw.WriteLine(sr);
                }
            }
        }

        public string GetPath()
        {
            return path;
        }

        public static string GetThePath()
        {
            return thePath;
        }

        public void ColourPicker(MouseEvent me, int x, int y, MouseEvent flags)
        {
            switch (me)
            {
                case MouseEvent.LButtonDown:
                    colourPoint = new Point(x, y);
                    colourPicked = true;
                    break;
            }
        }

        public void SetMinimumSaturation(int value)
        {
            elementSm = value;
        }

        public void SetMaximumSaturation(int value)
        {
            elementSM = value;
        }

        public void SetMinimumValue(int value)
        {
            elementVm = value;
        }

        public void SetMaximumValue(int value)
        {
            elementVM = value;
        }
    }
}
