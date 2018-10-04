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
    public partial class Form4 : Form
    {
        private Window colourWindow;
        private ColourCalibration colourCalibration;
        private VideoCapture cam;
        private const int CP_NOCLOSE_BUTTON = 0x200;
        private int current_smin, current_smax, current_vmin, current_vmax;

        public Form4()
        {
            InitializeComponent();
            colourCalibration = new ColourCalibration();
            colourWindow = new Window("Color Calibration Window");
            Cv2.SetMouseCallback(colourWindow.Name, colourCalibration.ColourPicker);
            cam = new VideoCapture(FormMain.GetCamera());
            cam.Set(CaptureProperty.FrameWidth, CamCalibration.GetResolution()[0]);
            cam.Set(CaptureProperty.FrameHeight, CamCalibration.GetResolution()[1]);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            current_smin = -1;
            current_smax = -1;
            current_vmin = -1;
            current_vmax = -1;
            colourWindow.Move(400, 0);
        }

        private void button_AddColor_Click(object sender, EventArgs e)
        {
            if (colourCalibration.AddNewColour)
            {
                colourCalibration.AddColour();
                button3.Enabled = true;
            }
            label2.Text = "# " + colourCalibration.GetColoursAdded();
            colourCalibration.AddNewColour = false;
            colourCalibration.Hue = -1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (colourCalibration.AddNewColour)
            {
                colorSquare.Text = "";
                colorSquare.BackColor = colourCalibration.GetNewColor();
            }
            else
            {
                colorSquare.Text = "NC";
                colorSquare.BackColor = Color.Transparent;
            }

            if (colourCalibration.Hue == -1)
            {
                label_hueValue.Text = "PICK A COLOR";
                label_hueValue.Font = new Font(label_hueValue.Font, FontStyle.Underline);
            }
            else
            {
                label_hueValue.Text = colourCalibration.Hue.ToString();
                label_hueValue.Font = new Font(label_hueValue.Font, FontStyle.Regular);
            }

            if(current_smin != trackBar_smin.Value)
            {
                current_smin = trackBar_smin.Value;
                colourCalibration.SetMinimumSaturation(current_smin);
                label_smin.Text = current_smin.ToString();
            }
            if(current_smax != trackBar_smax.Value)
            {
                current_smax = trackBar_smax.Value;
                colourCalibration.SetMaximumSaturation(current_smax);
                label_smax.Text = current_smax.ToString();
            }
            if(current_vmin != trackBar_vmin.Value)
            {
                current_vmin = trackBar_vmin.Value;
                colourCalibration.SetMinimumValue(current_vmin);
                label_vmin.Text = current_vmin.ToString();
            }
            if(current_vmax != trackBar_vmax.Value)
            {
                current_vmax = trackBar_vmax.Value;
                colourCalibration.SetMaximumValue(current_vmax);
                label_vmax.Text = current_vmax.ToString();
            }

            if(textBox_FileName.Text != "")
            {
                colourCalibration.SetPath(textBox_FileName.Text);
                if (!File.Exists(colourCalibration.GetPath()))
                {
                    textBox_FileName.BackColor = Color.LightGreen;
                    if (colourCalibration.AddNewColour)
                        button_AddColor.Enabled = true;
                    else
                        button_AddColor.Enabled = false;
                }
                else
                {
                    textBox_FileName.BackColor = Color.IndianRed;
                }
            }
            else
            {
                textBox_FileName.BackColor = Color.IndianRed;
            }

            colourCalibration.ColourLoop(cam, colourWindow);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colourCalibration.SetBlobView(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colourCalibration.SetBlobView(true);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cv2.DestroyWindow(colourWindow.Name);
            cam.Release();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colourCalibration.SaveFile();
            Cv2.DestroyWindow(colourWindow.Name);
            cam.Release();
            Close();
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
