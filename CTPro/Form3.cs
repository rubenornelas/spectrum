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
        CvTrackbar trackbarE;

        public Form3()
        {
            InitializeComponent();
            main = new Main();
            cam = new VideoCapture(Form1.GetCamera());
            cam.Set(CaptureProperty.FrameWidth, CamCalibration.GetResolution()[0]);
            cam.Set(CaptureProperty.FrameHeight, CamCalibration.GetResolution()[1]);
            Main.FillColorList();
            srcWindow = new Window("Main Window");
            dstWindow = new Window("Blob Window");
            trackbarE = new CvTrackbar("Morph Value", dstWindow.Name, 3, 21, main.OnNewTrackbarValueE, null);
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            main.MainLoop(cam, srcWindow, dstWindow);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cv2.DestroyWindow(srcWindow.Name);
            cam.Release();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main.SetReal(true);
            srcWindow = new Window("Main Window");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Main.SetBlob(false);
            Cv2.DestroyWindow(dstWindow.Name);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main.SetBlob(true);
            dstWindow = new Window("Blob Window");
            trackbarE = new CvTrackbar("Morph Value", dstWindow.Name, 3, 21, main.OnNewTrackbarValueE, null);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main.SetReal(false);
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
