using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using System.IO;

namespace CTPro
{
    public partial class Form2 : Form
    {
        private VideoCapture cam_test;
        private CamCalibration camCalibration;
        private Window calWindow;
        private int calNumber, previousPoint;
        private const int CP_NOCLOSE_BUTTON = 0x200;
        private bool fileSet, fileExists, pointsReady, x1_x2, x1_x3, y1_y3, y1_y4, x2_x4, y2_y3, y2_y4, x3_x4;

        public Form2()
        {
            InitializeComponent();
            calNumber++;
            camCalibration = new CamCalibration();
            camCalibration.ResetPoints();
            cam_test = new VideoCapture(FormMain.GetCamera());
            cam_test.Set(CaptureProperty.FrameWidth, CamCalibration.GetResolution()[0]);
            cam_test.Set(CaptureProperty.FrameHeight, CamCalibration.GetResolution()[1]);
            calWindow = new Window("Calibration Window " + calNumber);
            Cv2.SetMouseCallback(calWindow.Name, camCalibration.Click); // Need to be outside of the loop
            FormBorderStyle = FormBorderStyle.FixedSingle;
            calWindow.Move(450, 0);
            pointsReady = false;
            previousPoint = 0;
            label_point1.MouseEnter += OnMouseEnterPoint1;
            label_point1.MouseLeave += OnMouseLeavePoint1;
            label_point2.MouseEnter += OnMouseEnterPoint2;
            label_point2.MouseLeave += OnMouseLeavePoint2;
            label_point3.MouseEnter += OnMouseEnterPoint3;
            label_point3.MouseLeave += OnMouseLeavePoint3;
            label_point4.MouseEnter += OnMouseEnterPoint4;
            label_point4.MouseLeave += OnMouseLeavePoint4;
        }

        private void OnMouseEnterPoint1(object sender, EventArgs e)
        {
            label_point1.BackColor = Color.Bisque;
        }
        private void OnMouseLeavePoint1(object sender, EventArgs e)
        {
            if (camCalibration.GetCurrentPoint() == 1)
                label_point1.BackColor = Color.Aqua;
            else
                label_point1.BackColor = Color.AliceBlue;
        }

        private void OnMouseEnterPoint2(object sender, EventArgs e)
        {
            label_point2.BackColor = Color.Bisque;
        }
        private void OnMouseLeavePoint2(object sender, EventArgs e)
        {
            if (camCalibration.GetCurrentPoint() == 2)
                label_point2.BackColor = Color.Aqua;
            else
                label_point2.BackColor = Color.AliceBlue;
        }

        private void OnMouseEnterPoint3(object sender, EventArgs e)
        {
            label_point3.BackColor = Color.Bisque;
        }
        private void OnMouseLeavePoint3(object sender, EventArgs e)
        {
            if (camCalibration.GetCurrentPoint() == 3)
                label_point3.BackColor = Color.Aqua;
            else
                label_point3.BackColor = Color.AliceBlue;
        }

        private void OnMouseEnterPoint4(object sender, EventArgs e)
        {
            label_point4.BackColor = Color.Bisque;
        }
        private void OnMouseLeavePoint4(object sender, EventArgs e)
        {
            if (camCalibration.GetCurrentPoint() == 4)
                label_point4.BackColor = Color.Aqua;
            else
                label_point4.BackColor = Color.AliceBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cv2.DestroyWindow(calWindow.Name);
            cam_test.Release();
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (previousPoint != camCalibration.GetCurrentPoint())
            {
                previousPoint = camCalibration.GetCurrentPoint();
                switch (camCalibration.GetCurrentPoint())
                {
                    case 1:
                        label_point1.BackColor = Color.Aqua;
                        label_point2.BackColor = Color.AliceBlue;
                        label_point3.BackColor = Color.AliceBlue;
                        label_point4.BackColor = Color.AliceBlue;
                        break;
                    case 2:
                        label_point1.BackColor = Color.AliceBlue;
                        label_point2.BackColor = Color.Aqua;
                        label_point3.BackColor = Color.AliceBlue;
                        label_point4.BackColor = Color.AliceBlue;
                        break;
                    case 3:
                        label_point1.BackColor = Color.AliceBlue;
                        label_point2.BackColor = Color.AliceBlue;
                        label_point3.BackColor = Color.Aqua;
                        label_point4.BackColor = Color.AliceBlue;
                        break;
                    case 4:
                        label_point1.BackColor = Color.AliceBlue;
                        label_point2.BackColor = Color.AliceBlue;
                        label_point3.BackColor = Color.AliceBlue;
                        label_point4.BackColor = Color.Aqua;
                        break;
                }
            }

            textBox_point1X.Text = CamCalibration.GetROIPoints()[0].X.ToString();
            textBox_point1Y.Text = CamCalibration.GetROIPoints()[0].Y.ToString();

            textBox_point2X.Text = CamCalibration.GetROIPoints()[1].X.ToString();
            textBox_point2Y.Text = CamCalibration.GetROIPoints()[1].Y.ToString();

            textBox_point3X.Text = CamCalibration.GetROIPoints()[2].X.ToString();
            textBox_point3Y.Text = CamCalibration.GetROIPoints()[2].Y.ToString();

            textBox_point4X.Text = CamCalibration.GetROIPoints()[3].X.ToString();
            textBox_point4Y.Text = CamCalibration.GetROIPoints()[3].Y.ToString();

            if (CamCalibration.GetROIPoints()[0].X >= CamCalibration.GetROIPoints()[1].X)
            {
                textBox_point2X.BackColor = Color.IndianRed;
                x1_x2 = false;
            }
            else
            {
                textBox_point2X.BackColor = Color.White;
                x1_x2 = true;
            }
            if(CamCalibration.GetROIPoints()[0].X >= CamCalibration.GetROIPoints()[2].X)
            {
                textBox_point3X.BackColor = Color.IndianRed;
                x1_x3 = false;
            }
            else
            {
                textBox_point3X.BackColor = Color.White;
                x1_x3 = true;
            }
            if(CamCalibration.GetROIPoints()[0].Y >= CamCalibration.GetROIPoints()[2].Y)
            {
                textBox_point3Y.BackColor = Color.IndianRed;
                y1_y3 = false;
            }
            else
            {
                textBox_point3Y.BackColor = Color.White;
                y1_y3 = true;
            }
            if(CamCalibration.GetROIPoints()[0].Y >= CamCalibration.GetROIPoints()[3].Y)
            {
                textBox_point4Y.BackColor = Color.IndianRed;
                y1_y4 = false;
            }
            else
            {
                textBox_point4Y.BackColor = Color.White;
                y1_y4 = true;
            }
            if(CamCalibration.GetROIPoints()[1].X <= CamCalibration.GetROIPoints()[3].X)
            {
                textBox_point4X.BackColor = Color.IndianRed;
                x2_x4 = false;
            }
            else
            {
                textBox_point4X.BackColor = Color.White;
                x2_x4 = true;
            }
            if(CamCalibration.GetROIPoints()[1].Y >= CamCalibration.GetROIPoints()[2].Y)
            {
                textBox_point3Y.BackColor = Color.IndianRed;
                y2_y3 = false;
            }
            else
            {
                textBox_point3Y.BackColor = Color.White;
                y2_y3 = true;
            }
            if(CamCalibration.GetROIPoints()[1].Y >= CamCalibration.GetROIPoints()[3].Y)
            {
                textBox_point4Y.BackColor = Color.IndianRed;
                y2_y4 = false;
            }
            else
            {
                textBox_point4Y.BackColor = Color.White;
                y2_y4 = true;
            }
            if(CamCalibration.GetROIPoints()[2].X <= CamCalibration.GetROIPoints()[3].X)
            {
                textBox_point4X.BackColor = Color.IndianRed;
                x3_x4 = false;
            }
            else
            {
                textBox_point4X.BackColor = Color.White;
                x3_x4 = true;
            }

            if(x1_x2 && x1_x3 && y1_y3 && y1_y4 && x2_x4 && y2_y3 && y2_y4 && x3_x4)
            {
                pointsReady = true;
            }
            else
            {
                pointsReady = false;
            }

            if (textBox_fileName.Text != "")
            {
                CamCalibration.SetPath(textBox_fileName.Text);
                if (!File.Exists(CamCalibration.GetPath()))
                {
                    textBox_fileName.BackColor = Color.LightGreen;
                    fileSet = true;
                    fileExists = false;
                }
                else if (File.Exists(CamCalibration.GetPath()))
                {
                    textBox_fileName.BackColor = Color.Yellow;
                    fileSet = true;
                    fileExists = true;
                }
                else
                {
                    fileSet = false;
                    textBox_fileName.BackColor = Color.IndianRed;
                }
            }
            else
            {
                fileSet = false;
                textBox_fileName.BackColor = Color.IndianRed;
            }

            if (pointsReady && fileSet)
            {
                button_addFile.Enabled = true;
            }
            else
            {
                button_addFile.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            camCalibration.CropLoop(cam_test, calWindow);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void label_point1_Click(object sender, EventArgs e)
        {
            camCalibration.SetCurrentPoint(1);
        }

        private void label_point2_Click(object sender, EventArgs e)
        {
            camCalibration.SetCurrentPoint(2);
        }

        private void label_point3_Click(object sender, EventArgs e)
        {
            camCalibration.SetCurrentPoint(3);
        }

        private void label_point4_Click(object sender, EventArgs e)
        {
            camCalibration.SetCurrentPoint(4);
        }

        private void button_addFile_Click(object sender, EventArgs e)
        {
            string[] s = new string[4]
            {
                CamCalibration.GetROIPoints()[0].X + "/" + CamCalibration.GetROIPoints()[0].Y,
                CamCalibration.GetROIPoints()[1].X + "/" + CamCalibration.GetROIPoints()[1].Y,
                CamCalibration.GetROIPoints()[2].X + "/" + CamCalibration.GetROIPoints()[2].Y,
                CamCalibration.GetROIPoints()[3].X + "/" + CamCalibration.GetROIPoints()[3].Y
            };
            
            if (fileExists)
            {
                DialogResult result = MessageBox.Show("Save over file?", "Saving file...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    camCalibration.SaveFile(s);
                    MessageBox.Show("File Saved!", "Saving file...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                camCalibration.SaveFile(s);
                MessageBox.Show("File saved!", "Saving file...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
