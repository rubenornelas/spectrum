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

namespace CTPro
{
    public partial class Form3 : Form
    {
        private VideoCapture cam;
        private Window srcWindow, dstWindow;
        private Main main;
        private const int CP_NOCLOSE_BUTTON = 0x200;

        public Form3()
        {
            InitializeComponent();
            main = new Main();
            cam = new VideoCapture(FormMain.GetCamera());
            cam.Set(CaptureProperty.FrameWidth, CamCalibration.GetResolution()[0]);
            cam.Set(CaptureProperty.FrameHeight, CamCalibration.GetResolution()[1]);
            Main.FillColorList(Main.colorCalibrationPath);
            srcWindow = new Window("Main Window");
            dstWindow = new Window("Blob Window");
            FormBorderStyle = FormBorderStyle.FixedSingle;
            srcWindow.Move(300, 0);
            Main.MorphValue = 7;
            trackBar_morph.Value = 7;
            labelCurrentIP.Text = "IP: " + Main.IP_udp;
            labelCurrentPort.Text = "PORT: " + Main.Port_udp;
            areaResult_min.Text = Main.MinBlobArea.ToString();
            areaResult_max.Text = Main.MaxBlobArea.ToString();
            label_calCam.Text = Main.CameraFileName;
            label_calColor.Text = Main.ColorFileName;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            main.SpectrumTrack(cam, srcWindow, dstWindow);
            if(trackBar_morph.Value != Main.MorphValue)
            {
                Main.MorphValue = trackBar_morph.Value;
                label_morphValue.Text = "MORPH VALUE: " + Main.MorphValue;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cv2.DestroyWindow(srcWindow.Name);
            cam.Release();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main.SetRealView(true);
            srcWindow = new Window("Main Window");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Main.SetBlobView(false);
            Cv2.DestroyWindow(dstWindow.Name);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main.SetBlobView(true);
            dstWindow = new Window("Blob Window");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main.SetRealView(false);
            Cv2.DestroyWindow(srcWindow.Name);            
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
    }
}
