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
    public partial class FormMain : Form
    {
        private Form2 form2;
        private Form3 form3;
        private Form4 form4;
        private static int camera;
        private string[] filesArray, resolutions;
        private DirectoryInfo dinfo_cal, dinfo_cam;
        private FileInfo[] calFiles, camFiles;
        private bool onCamCalibration, wrongInput_IP, wrongInput_Port, ip_done, port_done, 
            wrongInput_minArea, wrongInput_maxArea, minArea_done, maxArea_done;
        private DsDevice[] cameras;
        private int lastCamera_count, wrongInput_IPCounter, wrongInput_PortCounter, 
            ip_doneCounter, port_doneCounter, wrongInput_minAreaCounter, wrongInput_maxAreaCounter,
            minArea_doneCounter, maxArea_doneCounter;

        public FormMain()
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
                listBox_Resolution.Items.Add(s);
            }
            listBox_Resolution.SelectedIndex = 0;
            filesArray = new string[] { };
            dinfo_cal = new DirectoryInfo(Path.Combine(Environment.CurrentDirectory, @"ColourFiles"));
            calFiles = dinfo_cal.GetFiles("*.txt");
            foreach(FileInfo f in calFiles)
            {
                listBox_ColorCal.Items.Add(f.Name);
            }
            dinfo_cam = new DirectoryInfo(Path.Combine(Environment.CurrentDirectory, @"CamFiles"));
            camFiles = dinfo_cam.GetFiles("*.txt");
            foreach(FileInfo f in camFiles)
            {
                listBox_CamCal.Items.Add(f.Name);
            }
            FormBorderStyle = FormBorderStyle.FixedSingle;
            lastCamera_count = 0;

            textBoxIP.MaxLength = 15;
            textBoxPORT.MaxLength = 5;

            Main.IP_udp = "127.0.0.1";
            labelCurrentIP.Text = "IP: " + Main.IP_udp;

            wrongInput_IP = false;
            wrongInput_IPCounter = 6;
            ip_done = false;
            ip_doneCounter = 6;

            Main.Port_udp = 1202;
            labelCurrentPort.Text = "PORT: " + 1202;

            Main.MinBlobArea = 5;
            minAreaResult.Text = "5";
            Main.MaxBlobArea = 50000;
            maxAreaResult.Text = "50000";

            wrongInput_Port = false;
            wrongInput_PortCounter = 6;
            port_done = false;
            port_doneCounter = 6;

            wrongInput_minArea = false;
            wrongInput_minAreaCounter = 6;
            minArea_done = false;
            minArea_doneCounter = 6;

            wrongInput_maxArea = false;
            wrongInput_maxAreaCounter = 6;
            maxArea_done = false;
            maxArea_doneCounter = 6;
        }

        public static int GetCamera()
        {
            return camera;
        }

        private void button_deleteCamCal_Click(object sender, EventArgs e)
        {
            string name = camFiles[listBox_CamCal.SelectedIndex].Name;
            string[] finalName = name.Split('-');
            string message = "Delete file " + name + "?";
            var result = MessageBox.Show(message, "Deleting file...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //camFiles[listBox_CamCal.SelectedIndex].Delete();
                foreach (FileInfo file in dinfo_cam.GetFiles())
                {
                    string[] nameSplit = file.Name.Split('-');
                    if (nameSplit[0] == finalName[0])
                    {
                        file.Delete();
                    }
                }
                listBox_CamCal.Items.Clear();
                camFiles = dinfo_cam.GetFiles("*.txt");
                foreach(FileInfo f in camFiles)
                {
                    listBox_CamCal.Items.Add(f.Name);
                }
            }
        }

        private void button_deleteColorCal_Click(object sender, EventArgs e)
        {
            string name = calFiles[listBox_ColorCal.SelectedIndex].Name;
            string[] finalName = name.Split('-');
            string message = "Delete file " + name + "?";
            DialogResult result = MessageBox.Show(message, "Deleting file...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                foreach (FileInfo file in dinfo_cal.GetFiles())
                {
                    string[] nameSplit = file.Name.Split('-');
                    if (nameSplit[0] == finalName[0])
                    {
                        file.Delete();
                    }
                }
                listBox_ColorCal.Items.Clear();
                calFiles = dinfo_cal.GetFiles("*.txt");
                foreach(FileInfo f in calFiles)
                {
                    listBox_ColorCal.Items.Add(f.Name);
                }
            }
        }

        private void button_minArea_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_minimumArea.Text))
            {
                if (int.TryParse(textBox_minimumArea.Text, out int result) && result < Main.MaxBlobArea)
                {
                    Main.MinBlobArea = result;
                    textBox_minimumArea.Text = null;
                    minAreaResult.Text = result.ToString();
                    minAreaResult.BackColor = Color.LightGreen;
                    minArea_done = true;
                }
                else
                {
                    textBox_minimumArea.BackColor = Color.IndianRed;
                    wrongInput_minArea = true;
                }
            }
            else
            {
                textBox_minimumArea.BackColor = Color.IndianRed;
                wrongInput_minArea = true;
            }
        }

        private void button_maxArea_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_maximumArea.Text))
            {
                if (int.TryParse(textBox_maximumArea.Text, out int result) && result > Main.MinBlobArea)
                {
                    Main.MaxBlobArea = result;
                    textBox_maximumArea.Text = null;
                    maxAreaResult.Text = result.ToString();
                    maxAreaResult.BackColor = Color.LightGreen;
                    maxArea_done = true;
                }
                else
                {
                    textBox_maximumArea.BackColor = Color.IndianRed;
                    wrongInput_maxArea = true;
                }
            }
            else
            {
                textBox_maximumArea.BackColor = Color.IndianRed;
                wrongInput_maxArea = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            onCamCalibration = true;
            ResSelection(listBox_Resolution.SelectedIndex);
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
            listBox_CamCal.Items.Clear();
            camFiles = dinfo_cam.GetFiles("*.txt");
            foreach (FileInfo f in camFiles)
            {
                listBox_CamCal.Items.Add(f.Name);
            }
            Cv2.DestroyAllWindows();
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResSelection(listBox_Resolution.SelectedIndex);
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
            ResSelection(listBox_Resolution.SelectedIndex);
            form4 = new Form4();
            form4.StartPosition = FormStartPosition.Manual;
            form4.Location = new System.Drawing.Point(0, 0);
            form4.Show();
            form4.FormClosed += new FormClosedEventHandler(Form4_FormClosed);
            Hide();
        }

        private void buttonIP_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(textBoxIP.Text))
            {
                string[] firstSplit = textBoxIP.Text.Split('.');
                if(firstSplit.Length == 4)
                {
                    Main.IP_udp = textBoxIP.Text;
                    labelCurrentIP.Text = "IP: " + Main.IP_udp;
                    textBoxIP.Text = null;
                    ip_done = true;
                    labelCurrentIP.BackColor = Color.LightGreen;
                }
                else
                {
                    textBoxIP.BackColor = Color.IndianRed;
                    wrongInput_IP = true;
                }
            }
            else
            {
                textBoxIP.BackColor = Color.IndianRed;
                wrongInput_IP = true;
            }
        }

        private void buttonPort_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxPORT.Text))
            {
                if (IsDigitsOnly(textBoxPORT.Text))
                {
                    labelCurrentPort.Text = "PORT: " + textBoxPORT.Text;
                    Main.Port_udp = int.Parse(textBoxPORT.Text);
                    labelCurrentPort.BackColor = Color.LightGreen;
                    port_done = true;
                    textBoxPORT.Text = null;
                }
                else
                {
                    textBoxPORT.BackColor = Color.IndianRed;
                    wrongInput_Port = true;
                }
            }
            else
            {
                textBoxPORT.BackColor = Color.IndianRed;
                wrongInput_Port = true;
            }
        }

        private bool IsDigitsOnly(string text)
        {
            foreach(char c in text)
            {
                if(c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            listBox_ColorCal.Items.Clear();
            calFiles = dinfo_cal.GetFiles("*.txt");
            foreach (FileInfo f in calFiles)
            {
                listBox_ColorCal.Items.Add(f.Name);
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
                listBox_Cameras.Items.Clear();
                for (int i = 0; i < cameras.Length; i++)
                {
                    listBox_Cameras.Items.Add(cameras[i].Name);
                }
                listBox_Cameras.SelectedIndex = 0;
            }

            camera = listBox_Cameras.SelectedIndex;

            if (listBox_CamCal.SelectedIndex >= 0)
                button_deleteCamCal.Enabled = true;
            else
                button_deleteCamCal.Enabled = false;

            if (listBox_ColorCal.SelectedIndex >= 0)
                button_deleteColorCal.Enabled = true;
            else
                button_deleteColorCal.Enabled = false;

            if (listBox_Cameras.SelectedIndex >= 0 && listBox_Resolution.SelectedIndex >= 0 && listBox_ColorCal.SelectedIndex >= 0 && listBox_CamCal.SelectedIndex >= 0)
            {
                Main.ColorCalibrationPath(listBox_ColorCal.SelectedItem.ToString());
                Main.ColorFileName = listBox_ColorCal.SelectedItem.ToString();

                if (!onCamCalibration)
                {
                    Main.CameraFileName = listBox_CamCal.SelectedItem.ToString();
                    CamCalibration.SetPath(listBox_CamCal.SelectedItem.ToString());
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
            else
            {
                button3.Enabled = false;
            }

            if (checkBox1.Checked)
            {
                Main.SetOrientation(false);
            }
            else
            {
                Main.SetOrientation(true);
            }

            if (wrongInput_IP)
            {
                if(wrongInput_IPCounter <= 0)
                {
                    textBoxIP.BackColor = Color.White;
                    wrongInput_IP = false;
                    wrongInput_IPCounter = 6;
                }
                else
                {
                    wrongInput_IPCounter--;
                }
            }

            if (ip_done)
            {
                if(ip_doneCounter <= 0)
                {
                    ip_done = false;
                    labelCurrentIP.BackColor = Color.Transparent;
                }
                else
                {
                    ip_doneCounter--;
                }
            }

            if (wrongInput_Port)
            {
                if(wrongInput_PortCounter <= 0)
                {
                    textBoxPORT.BackColor = Color.White;
                    wrongInput_Port = false;
                    wrongInput_PortCounter = 6;
                }
                else
                {
                    wrongInput_PortCounter--;
                }
            }

            if (port_done)
            {
                if(port_doneCounter <= 0)
                {
                    labelCurrentPort.BackColor = Color.Transparent;
                    port_done = false;
                    port_doneCounter = 6;
                }
                else
                {
                    port_doneCounter--;
                }
            }

            if (wrongInput_minArea)
            {
                if(wrongInput_minAreaCounter <= 0)
                {
                    textBox_minimumArea.BackColor = Color.White;
                    wrongInput_minArea = false;
                    wrongInput_minAreaCounter = 6;
                }
                else
                {
                    wrongInput_minAreaCounter--;
                }
            }

            if (minArea_done)
            {
                if(minArea_doneCounter <= 0)
                {
                    minAreaResult.BackColor = Color.Transparent;
                    minArea_done = false;
                    minArea_doneCounter = 6;
                }
                else
                {
                    minArea_doneCounter--;
                }
            }

            if (wrongInput_maxArea)
            {
                if (wrongInput_maxAreaCounter <= 0)
                {
                    textBox_maximumArea.BackColor = Color.White;
                    wrongInput_maxArea = false;
                    wrongInput_maxAreaCounter = 6;
                }
                else
                {
                    wrongInput_maxAreaCounter--;
                }
            }

            if (maxArea_done)
            {
                if (maxArea_doneCounter <= 0)
                {
                    maxAreaResult.BackColor = Color.Transparent;
                    maxArea_done = false;
                    maxArea_doneCounter = 6;
                }
                else
                {
                    maxArea_doneCounter--;
                }
            }

            if (listBox_Cameras.SelectedIndex >= 0)
                label_CameraBool.BackColor = Color.LightGreen;
            else
                label_CameraBool.BackColor = Color.IndianRed;

            if(listBox_Resolution.SelectedIndex >= 0)
                label_ResolutionBool.BackColor = Color.LightGreen;
            else
                label_ResolutionBool.BackColor = Color.IndianRed;

            if(listBox_CamCal.SelectedIndex >= 0)
                label_CamCalBool.BackColor = Color.LightGreen;
            else
                label_CamCalBool.BackColor = Color.IndianRed;

            if (listBox_ColorCal.SelectedIndex >= 0)
                label_ColorCalBool.BackColor = Color.LightGreen;
            else
                label_ColorCalBool.BackColor = Color.IndianRed;
        }
    }
}
