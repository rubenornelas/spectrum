namespace CTPro
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.maxAreaResult = new System.Windows.Forms.Label();
            this.minAreaResult = new System.Windows.Forms.Label();
            this.button_maxArea = new System.Windows.Forms.Button();
            this.button_minArea = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_maximumArea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_minimumArea = new System.Windows.Forms.TextBox();
            this.label_blobArea = new System.Windows.Forms.Label();
            this.buttonPort = new System.Windows.Forms.Button();
            this.buttonIP = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPORT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listBox_Resolution = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_Cameras = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_deleteColorCal = new System.Windows.Forms.Button();
            this.button_deleteCamCal = new System.Windows.Forms.Button();
            this.listBox_ColorCal = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox_CamCal = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelCurrentPort = new System.Windows.Forms.Label();
            this.labelCurrentIP = new System.Windows.Forms.Label();
            this.label_CameraBool = new System.Windows.Forms.Label();
            this.label_ResolutionBool = new System.Windows.Forms.Label();
            this.label_CamCalBool = new System.Windows.Forms.Label();
            this.label_ColorCalBool = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(307, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 49);
            this.button3.TabIndex = 2;
            this.button3.Text = "START";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(470, 390);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.maxAreaResult);
            this.tabPage1.Controls.Add(this.minAreaResult);
            this.tabPage1.Controls.Add(this.button_maxArea);
            this.tabPage1.Controls.Add(this.button_minArea);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBox_maximumArea);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox_minimumArea);
            this.tabPage1.Controls.Add(this.label_blobArea);
            this.tabPage1.Controls.Add(this.buttonPort);
            this.tabPage1.Controls.Add(this.buttonIP);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBoxPORT);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBoxIP);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.listBox_Resolution);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.listBox_Cameras);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(462, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // maxAreaResult
            // 
            this.maxAreaResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maxAreaResult.AutoSize = true;
            this.maxAreaResult.BackColor = System.Drawing.Color.Transparent;
            this.maxAreaResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxAreaResult.Location = new System.Drawing.Point(312, 297);
            this.maxAreaResult.Name = "maxAreaResult";
            this.maxAreaResult.Size = new System.Drawing.Size(64, 18);
            this.maxAreaResult.TabIndex = 34;
            this.maxAreaResult.Text = "0000000";
            // 
            // minAreaResult
            // 
            this.minAreaResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.minAreaResult.AutoSize = true;
            this.minAreaResult.BackColor = System.Drawing.Color.Transparent;
            this.minAreaResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minAreaResult.Location = new System.Drawing.Point(312, 263);
            this.minAreaResult.Name = "minAreaResult";
            this.minAreaResult.Size = new System.Drawing.Size(64, 18);
            this.minAreaResult.TabIndex = 33;
            this.minAreaResult.Text = "0000000";
            // 
            // button_maxArea
            // 
            this.button_maxArea.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_maxArea.BackColor = System.Drawing.SystemColors.Control;
            this.button_maxArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_maxArea.Location = new System.Drawing.Point(225, 292);
            this.button_maxArea.Name = "button_maxArea";
            this.button_maxArea.Size = new System.Drawing.Size(80, 28);
            this.button_maxArea.TabIndex = 32;
            this.button_maxArea.Text = "SET MAX";
            this.button_maxArea.UseVisualStyleBackColor = false;
            this.button_maxArea.Click += new System.EventHandler(this.button_maxArea_Click);
            // 
            // button_minArea
            // 
            this.button_minArea.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_minArea.BackColor = System.Drawing.SystemColors.Control;
            this.button_minArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minArea.Location = new System.Drawing.Point(225, 258);
            this.button_minArea.Name = "button_minArea";
            this.button_minArea.Size = new System.Drawing.Size(80, 28);
            this.button_minArea.TabIndex = 31;
            this.button_minArea.Text = "SET MIN";
            this.button_minArea.UseVisualStyleBackColor = false;
            this.button_minArea.Click += new System.EventHandler(this.button_minArea_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "MAXIMUM";
            // 
            // textBox_maximumArea
            // 
            this.textBox_maximumArea.Location = new System.Drawing.Point(124, 296);
            this.textBox_maximumArea.Name = "textBox_maximumArea";
            this.textBox_maximumArea.Size = new System.Drawing.Size(94, 22);
            this.textBox_maximumArea.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "MINIMUM";
            // 
            // textBox_minimumArea
            // 
            this.textBox_minimumArea.Location = new System.Drawing.Point(124, 262);
            this.textBox_minimumArea.Name = "textBox_minimumArea";
            this.textBox_minimumArea.Size = new System.Drawing.Size(94, 22);
            this.textBox_minimumArea.TabIndex = 27;
            // 
            // label_blobArea
            // 
            this.label_blobArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_blobArea.AutoSize = true;
            this.label_blobArea.BackColor = System.Drawing.Color.Transparent;
            this.label_blobArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_blobArea.Location = new System.Drawing.Point(24, 238);
            this.label_blobArea.Name = "label_blobArea";
            this.label_blobArea.Size = new System.Drawing.Size(91, 18);
            this.label_blobArea.TabIndex = 26;
            this.label_blobArea.Text = "BLOB AREA";
            // 
            // buttonPort
            // 
            this.buttonPort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPort.BackColor = System.Drawing.SystemColors.Control;
            this.buttonPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPort.Location = new System.Drawing.Point(251, 56);
            this.buttonPort.Name = "buttonPort";
            this.buttonPort.Size = new System.Drawing.Size(90, 28);
            this.buttonPort.TabIndex = 24;
            this.buttonPort.Text = "SET PORT";
            this.buttonPort.UseVisualStyleBackColor = false;
            this.buttonPort.Click += new System.EventHandler(this.buttonPort_Click);
            // 
            // buttonIP
            // 
            this.buttonIP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonIP.BackColor = System.Drawing.SystemColors.Control;
            this.buttonIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIP.Location = new System.Drawing.Point(251, 18);
            this.buttonIP.Name = "buttonIP";
            this.buttonIP.Size = new System.Drawing.Size(90, 28);
            this.buttonIP.TabIndex = 22;
            this.buttonIP.Text = "SET IP";
            this.buttonIP.UseVisualStyleBackColor = false;
            this.buttonIP.Click += new System.EventHandler(this.buttonIP_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "NEW PORT";
            // 
            // textBoxPORT
            // 
            this.textBoxPORT.Location = new System.Drawing.Point(124, 58);
            this.textBoxPORT.Name = "textBoxPORT";
            this.textBoxPORT.Size = new System.Drawing.Size(121, 22);
            this.textBoxPORT.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "NEW IP";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(124, 20);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(121, 22);
            this.textBoxIP.TabIndex = 20;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(340, 333);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 22);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "INVERT AXIS";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // listBox_Resolution
            // 
            this.listBox_Resolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Resolution.FormattingEnabled = true;
            this.listBox_Resolution.HorizontalScrollbar = true;
            this.listBox_Resolution.ItemHeight = 18;
            this.listBox_Resolution.Location = new System.Drawing.Point(315, 125);
            this.listBox_Resolution.Name = "listBox_Resolution";
            this.listBox_Resolution.Size = new System.Drawing.Size(129, 94);
            this.listBox_Resolution.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "RESOLUTION";
            // 
            // listBox_Cameras
            // 
            this.listBox_Cameras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Cameras.FormattingEnabled = true;
            this.listBox_Cameras.HorizontalScrollbar = true;
            this.listBox_Cameras.ItemHeight = 18;
            this.listBox_Cameras.Location = new System.Drawing.Point(27, 125);
            this.listBox_Cameras.Name = "listBox_Cameras";
            this.listBox_Cameras.Size = new System.Drawing.Size(271, 94);
            this.listBox_Cameras.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "CAMERA";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_deleteColorCal);
            this.tabPage2.Controls.Add(this.button_deleteCamCal);
            this.tabPage2.Controls.Add(this.listBox_ColorCal);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.listBox_CamCal);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(462, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calibrations";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_deleteColorCal
            // 
            this.button_deleteColorCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deleteColorCal.Location = new System.Drawing.Point(247, 296);
            this.button_deleteColorCal.Name = "button_deleteColorCal";
            this.button_deleteColorCal.Size = new System.Drawing.Size(180, 30);
            this.button_deleteColorCal.TabIndex = 16;
            this.button_deleteColorCal.Text = "DELETE COLOR FILE";
            this.button_deleteColorCal.UseVisualStyleBackColor = true;
            this.button_deleteColorCal.Click += new System.EventHandler(this.button_deleteColorCal_Click);
            // 
            // button_deleteCamCal
            // 
            this.button_deleteCamCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deleteCamCal.Location = new System.Drawing.Point(43, 296);
            this.button_deleteCamCal.Name = "button_deleteCamCal";
            this.button_deleteCamCal.Size = new System.Drawing.Size(180, 30);
            this.button_deleteCamCal.TabIndex = 15;
            this.button_deleteCamCal.Text = "DELETE CAMERA FILE";
            this.button_deleteCamCal.UseVisualStyleBackColor = true;
            this.button_deleteCamCal.Click += new System.EventHandler(this.button_deleteCamCal_Click);
            // 
            // listBox_ColorCal
            // 
            this.listBox_ColorCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_ColorCal.FormattingEnabled = true;
            this.listBox_ColorCal.ItemHeight = 18;
            this.listBox_ColorCal.Location = new System.Drawing.Point(247, 70);
            this.listBox_ColorCal.Name = "listBox_ColorCal";
            this.listBox_ColorCal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox_ColorCal.Size = new System.Drawing.Size(180, 220);
            this.listBox_ColorCal.Sorted = true;
            this.listBox_ColorCal.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 40);
            this.button2.TabIndex = 13;
            this.button2.Text = "COLOR CALIBRATION";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox_CamCal
            // 
            this.listBox_CamCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_CamCal.FormattingEnabled = true;
            this.listBox_CamCal.ItemHeight = 18;
            this.listBox_CamCal.Location = new System.Drawing.Point(43, 70);
            this.listBox_CamCal.Name = "listBox_CamCal";
            this.listBox_CamCal.Size = new System.Drawing.Size(180, 220);
            this.listBox_CamCal.Sorted = true;
            this.listBox_CamCal.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "CAMERA CALIBRATION\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCurrentPort
            // 
            this.labelCurrentPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCurrentPort.AutoSize = true;
            this.labelCurrentPort.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentPort.Location = new System.Drawing.Point(12, 434);
            this.labelCurrentPort.Name = "labelCurrentPort";
            this.labelCurrentPort.Size = new System.Drawing.Size(54, 18);
            this.labelCurrentPort.TabIndex = 21;
            this.labelCurrentPort.Text = "PORT:";
            // 
            // labelCurrentIP
            // 
            this.labelCurrentIP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCurrentIP.AutoSize = true;
            this.labelCurrentIP.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentIP.Location = new System.Drawing.Point(12, 407);
            this.labelCurrentIP.Name = "labelCurrentIP";
            this.labelCurrentIP.Size = new System.Drawing.Size(25, 18);
            this.labelCurrentIP.TabIndex = 20;
            this.labelCurrentIP.Text = "IP:";
            // 
            // label_CameraBool
            // 
            this.label_CameraBool.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_CameraBool.AutoSize = true;
            this.label_CameraBool.BackColor = System.Drawing.Color.White;
            this.label_CameraBool.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_CameraBool.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CameraBool.Location = new System.Drawing.Point(145, 403);
            this.label_CameraBool.MinimumSize = new System.Drawing.Size(75, 22);
            this.label_CameraBool.Name = "label_CameraBool";
            this.label_CameraBool.Padding = new System.Windows.Forms.Padding(2);
            this.label_CameraBool.Size = new System.Drawing.Size(75, 22);
            this.label_CameraBool.TabIndex = 22;
            this.label_CameraBool.Text = "CAMERA";
            this.label_CameraBool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ResolutionBool
            // 
            this.label_ResolutionBool.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_ResolutionBool.AutoSize = true;
            this.label_ResolutionBool.BackColor = System.Drawing.Color.White;
            this.label_ResolutionBool.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_ResolutionBool.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ResolutionBool.Location = new System.Drawing.Point(226, 403);
            this.label_ResolutionBool.MinimumSize = new System.Drawing.Size(75, 22);
            this.label_ResolutionBool.Name = "label_ResolutionBool";
            this.label_ResolutionBool.Padding = new System.Windows.Forms.Padding(2);
            this.label_ResolutionBool.Size = new System.Drawing.Size(75, 22);
            this.label_ResolutionBool.TabIndex = 23;
            this.label_ResolutionBool.Text = "RESOLUTION";
            this.label_ResolutionBool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_CamCalBool
            // 
            this.label_CamCalBool.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_CamCalBool.AutoSize = true;
            this.label_CamCalBool.BackColor = System.Drawing.Color.White;
            this.label_CamCalBool.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_CamCalBool.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CamCalBool.Location = new System.Drawing.Point(145, 430);
            this.label_CamCalBool.MinimumSize = new System.Drawing.Size(75, 22);
            this.label_CamCalBool.Name = "label_CamCalBool";
            this.label_CamCalBool.Padding = new System.Windows.Forms.Padding(2);
            this.label_CamCalBool.Size = new System.Drawing.Size(75, 22);
            this.label_CamCalBool.TabIndex = 24;
            this.label_CamCalBool.Text = "CAM_CAL";
            this.label_CamCalBool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ColorCalBool
            // 
            this.label_ColorCalBool.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_ColorCalBool.AutoSize = true;
            this.label_ColorCalBool.BackColor = System.Drawing.Color.White;
            this.label_ColorCalBool.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_ColorCalBool.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ColorCalBool.Location = new System.Drawing.Point(226, 430);
            this.label_ColorCalBool.MinimumSize = new System.Drawing.Size(75, 22);
            this.label_ColorCalBool.Name = "label_ColorCalBool";
            this.label_ColorCalBool.Padding = new System.Windows.Forms.Padding(2);
            this.label_ColorCalBool.Size = new System.Drawing.Size(75, 22);
            this.label_ColorCalBool.TabIndex = 25;
            this.label_ColorCalBool.Text = "COLOR_CAL";
            this.label_ColorCalBool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label_ColorCalBool);
            this.Controls.Add(this.label_CamCalBool);
            this.Controls.Add(this.label_ResolutionBool);
            this.Controls.Add(this.label_CameraBool);
            this.Controls.Add(this.labelCurrentPort);
            this.Controls.Add(this.labelCurrentIP);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button3);
            this.Name = "FormMain";
            this.Text = "Spectrum Detectio";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBox_Resolution;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_Cameras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox_ColorCal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox_CamCal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCurrentPort;
        private System.Windows.Forms.Label labelCurrentIP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPORT;
        private System.Windows.Forms.Button buttonPort;
        private System.Windows.Forms.Button buttonIP;
        private System.Windows.Forms.Label label_CameraBool;
        private System.Windows.Forms.Label label_ResolutionBool;
        private System.Windows.Forms.Label label_CamCalBool;
        private System.Windows.Forms.Label label_ColorCalBool;
        private System.Windows.Forms.Button button_deleteCamCal;
        private System.Windows.Forms.Button button_deleteColorCal;
        private System.Windows.Forms.Label label_blobArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_maximumArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_minimumArea;
        private System.Windows.Forms.Button button_maxArea;
        private System.Windows.Forms.Button button_minArea;
        private System.Windows.Forms.Label maxAreaResult;
        private System.Windows.Forms.Label minAreaResult;
    }
}

