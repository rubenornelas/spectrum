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
        private int calNumber;
        private const int CP_NOCLOSE_BUTTON = 0x200;
        private bool fileSet;

        public Form2()
        {
            InitializeComponent();
            calNumber++;
            camCalibration = new CamCalibration();
            camCalibration.ResetPoints();
            cam_test = new VideoCapture(Form1.GetCamera());
            cam_test.Set(CaptureProperty.FrameWidth, CamCalibration.GetResolution()[0]);
            cam_test.Set(CaptureProperty.FrameHeight, CamCalibration.GetResolution()[1]);
            calWindow = new Window("Calibration Window " + calNumber);
            Cv2.SetMouseCallback(calWindow.Name, camCalibration.Click); // Need to be outside of the loop
            FormBorderStyle = FormBorderStyle.FixedSingle;
            calWindow.Move(300, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cv2.DestroyWindow(calWindow.Name);
            cam_test.Release();
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Point 1: " + CamCalibration.GetROIPoints()[0];
            label2.Text = "Point 2: " + CamCalibration.GetROIPoints()[1];
            label3.Text = "Point 3: " + CamCalibration.GetROIPoints()[2];
            label4.Text = "Point 4: " + CamCalibration.GetROIPoints()[3];

            if(textBox1.Text != "")
            {
                CamCalibration.SetPath(textBox1.Text);
                if (!File.Exists(CamCalibration.GetPath()))
                {
                    textBox1.BackColor = Color.LightGreen;
                    fileSet = true;
                }
                else
                {
                    fileSet = false;
                    textBox1.BackColor = Color.IndianRed;
                }
            }
            else
            {
                fileSet = false;
                textBox1.BackColor = Color.IndianRed;
            }

            if (CamCalibration.GetROIPoints()[3] != new Point2f(0, 0) && fileSet)
            {
                button4.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
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

        private void button4_Click(object sender, EventArgs e)
        {
            string[] s = new String[4]
            {
                CamCalibration.GetROIPoints()[0].X + "/" + CamCalibration.GetROIPoints()[0].Y,
                CamCalibration.GetROIPoints()[1].X + "/" + CamCalibration.GetROIPoints()[1].Y,
                CamCalibration.GetROIPoints()[2].X + "/" + CamCalibration.GetROIPoints()[2].Y,
                CamCalibration.GetROIPoints()[3].X + "/" + CamCalibration.GetROIPoints()[3].Y
            };
            camCalibration.SaveFile(s);
        }
    }
}
