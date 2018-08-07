using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DirectShowLib;
using OpenCvSharp;
using System.IO;

namespace CTPro
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        private Form3 form3;
        private Form4 form4;
        private static int camera;
        private string[] filesArray, resolutions;
        private DirectoryInfo dinfo_cal, dinfo_cam;
        private FileInfo[] calFiles, camFiles;
        private bool onCamCalibration;
        private DsDevice[] cameras;
        private int lastCamera_count;

        public Form1()
        {
            InitializeComponent();
            resolutions = new string[4]
            {
                "640x480 4:3",
                "800x450 RS",
                "1440x1080 4:3",
                "1920x1080 RS"
            };
            foreach(string s in resolutions)
            {
                listBox4.Items.Add(s);
            }
            listBox4.SelectedIndex = 0;
            filesArray = new string[] { };
            dinfo_cal = new DirectoryInfo(Path.Combine(Environment.CurrentDirectory, @"ColourFiles"));
            calFiles = dinfo_cal.GetFiles("*.txt");
            foreach(FileInfo f in calFiles)
            {
                listBox1.Items.Add(f.Name);
            }
            dinfo_cam = new DirectoryInfo(Path.Combine(Environment.CurrentDirectory, @"CamFiles"));
            camFiles = dinfo_cam.GetFiles("*.txt");
            foreach(FileInfo f in camFiles)
            {
                listBox2.Items.Add(f.Name);
            }
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            lastCamera_count = 0;
        }

        public static int GetCamera()
        {
            return camera;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            onCamCalibration = true;
            ResSelection(listBox4.SelectedIndex);
            form2 = new Form2();
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = new System.Drawing.Point(0, 0);
            form2.Show();
            form2.FormClosed += new FormClosedEventHandler(Form2_FormClosed);
            Hide();
        }

        void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            onCamCalibration = false;
            listBox2.Items.Clear();
            camFiles = dinfo_cam.GetFiles("*.txt");
            foreach (FileInfo f in camFiles)
            {
                listBox2.Items.Add(f.Name);
            }
            Cv2.DestroyAllWindows();
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResSelection(listBox4.SelectedIndex);
            form3 = new Form3();
            form3.StartPosition = FormStartPosition.Manual;
            form3.Location = new System.Drawing.Point(0, 0);
            form3.Show();
            form3.FormClosed += new FormClosedEventHandler(Form3_FormClosed);
            timer1.Enabled = false;
            Hide();
        }

        void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cv2.DestroyAllWindows();
            timer1.Enabled = true;
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResSelection(listBox4.SelectedIndex);
            form4 = new Form4();
            form4.StartPosition = FormStartPosition.Manual;
            form4.Location = new System.Drawing.Point(0, 0);
            form4.Show();
            form4.FormClosed += new FormClosedEventHandler(Form4_FormClosed);
            Hide();
        }

        void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            listBox1.Items.Clear();
            calFiles = dinfo_cal.GetFiles("*.txt");
            foreach (FileInfo f in calFiles)
            {
                listBox1.Items.Add(f.Name);
            }
            Cv2.DestroyAllWindows();
            Show();
        }

        private void ResSelection(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0:
                    CamCalibration.SetFrameSize(640, 480);
                    CamCalibration.SetResolution(640, 480);
                    break;
                case 1:
                    CamCalibration.SetFrameSize(800, 450);
                    CamCalibration.SetResolution(800, 450);
                    break;
                case 2:
                    CamCalibration.SetFrameSize(640, 480);
                    CamCalibration.SetResolution(1440, 1080);
                    break;
                case 3:
                    CamCalibration.SetFrameSize(800, 480);
                    CamCalibration.SetResolution(1920, 1080);
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cameras = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            if (lastCamera_count != cameras.Length)
            {
                lastCamera_count = cameras.Length;
                listBox3.Items.Clear();
                for (int i = 0; i < cameras.Length; i++)
                {
                    listBox3.Items.Add(cameras[i].Name);
                }
                listBox3.SelectedIndex = 0;
            }

            camera = listBox3.SelectedIndex;

            if (listBox1.SelectedIndex >= 0 && listBox2.SelectedIndex >= 0)
            {
                Main.SetCalPath(listBox1.SelectedItem.ToString());

                if (!onCamCalibration)
                {
                    CamCalibration.SetPath(listBox2.SelectedItem.ToString());
                    List<string> camList = new List<string>();
                    using (StreamReader sr = File.OpenText(CamCalibration.GetPath()))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            camList.Add(s);
                        }
                    }
                    string[] camArray = camList.ToArray();
                    int counter = 0;
                    foreach (string s in camArray)
                    {
                        string[] xAndY = s.Split('/');
                        CamCalibration.SetPoints(new OpenCvSharp.Point(int.Parse(xAndY[0]), int.Parse(xAndY[1])), counter);
                        counter++;
                    }
                }
                button3.Enabled = true;
            }

            if (checkBox1.Checked)
            {
                Main.SetOrientation(false);
            }
            else
            {
                Main.SetOrientation(true);
            }
        }
    }
}
