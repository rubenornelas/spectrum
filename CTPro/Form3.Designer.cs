namespace CTPro
{
    partial class Form3
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
                cam.Dispose();
                dstWindow.Dispose();
                srcWindow.Dispose();
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
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar_morph = new System.Windows.Forms.TrackBar();
            this.label_morphValue = new System.Windows.Forms.Label();
            this.labelCurrentPort = new System.Windows.Forms.Label();
            this.labelCurrentIP = new System.Windows.Forms.Label();
            this.blobsArea = new System.Windows.Forms.Label();
            this.areaResult_min = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_calCam = new System.Windows.Forms.Label();
            this.label_calColor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.areaResult_max = new System.Windows.Forms.Label();
            this.checkBox_blobsLabel = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_morph)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(100, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "STOP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "SHOW";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(81, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "HIDE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(229, 48);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 38);
            this.button4.TabIndex = 4;
            this.button4.Text = "HIDE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(162, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 38);
            this.button5.TabIndex = 3;
            this.button5.Text = "SHOW";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "CAMERA IMAGE";
            // 
            // trackBar_morph
            // 
            this.trackBar_morph.Location = new System.Drawing.Point(2, 346);
            this.trackBar_morph.Maximum = 21;
            this.trackBar_morph.Name = "trackBar_morph";
            this.trackBar_morph.Size = new System.Drawing.Size(304, 45);
            this.trackBar_morph.TabIndex = 9;
            // 
            // label_morphValue
            // 
            this.label_morphValue.AutoSize = true;
            this.label_morphValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_morphValue.Location = new System.Drawing.Point(11, 325);
            this.label_morphValue.Name = "label_morphValue";
            this.label_morphValue.Size = new System.Drawing.Size(132, 18);
            this.label_morphValue.TabIndex = 10;
            this.label_morphValue.Text = "MORPH VALUE: 0";
            // 
            // labelCurrentPort
            // 
            this.labelCurrentPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCurrentPort.AutoSize = true;
            this.labelCurrentPort.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentPort.Location = new System.Drawing.Point(8, 475);
            this.labelCurrentPort.Name = "labelCurrentPort";
            this.labelCurrentPort.Size = new System.Drawing.Size(54, 18);
            this.labelCurrentPort.TabIndex = 23;
            this.labelCurrentPort.Text = "PORT:";
            // 
            // labelCurrentIP
            // 
            this.labelCurrentIP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCurrentIP.AutoSize = true;
            this.labelCurrentIP.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentIP.Location = new System.Drawing.Point(8, 450);
            this.labelCurrentIP.Name = "labelCurrentIP";
            this.labelCurrentIP.Size = new System.Drawing.Size(25, 18);
            this.labelCurrentIP.TabIndex = 22;
            this.labelCurrentIP.Text = "IP:";
            // 
            // blobsArea
            // 
            this.blobsArea.AutoSize = true;
            this.blobsArea.BackColor = System.Drawing.SystemColors.Control;
            this.blobsArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blobsArea.Location = new System.Drawing.Point(8, 191);
            this.blobsArea.Name = "blobsArea";
            this.blobsArea.Padding = new System.Windows.Forms.Padding(2);
            this.blobsArea.Size = new System.Drawing.Size(273, 22);
            this.blobsArea.TabIndex = 24;
            this.blobsArea.Text = "BLOBS AREA                                          ";
            // 
            // areaResult_min
            // 
            this.areaResult_min.AutoSize = true;
            this.areaResult_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaResult_min.Location = new System.Drawing.Point(97, 218);
            this.areaResult_min.Name = "areaResult_min";
            this.areaResult_min.Size = new System.Drawing.Size(43, 16);
            this.areaResult_min.TabIndex = 25;
            this.areaResult_min.Text = "50000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 110);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(2);
            this.label3.Size = new System.Drawing.Size(272, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "CALIBRATION                                         ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "CAMERA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "COLOR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "BLOB IMAGE";
            // 
            // label_calCam
            // 
            this.label_calCam.AutoSize = true;
            this.label_calCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_calCam.Location = new System.Drawing.Point(97, 137);
            this.label_calCam.Name = "label_calCam";
            this.label_calCam.Size = new System.Drawing.Size(77, 16);
            this.label_calCam.TabIndex = 29;
            this.label_calCam.Text = "FILE NAME";
            // 
            // label_calColor
            // 
            this.label_calColor.AutoSize = true;
            this.label_calColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_calColor.Location = new System.Drawing.Point(97, 161);
            this.label_calColor.Name = "label_calColor";
            this.label_calColor.Size = new System.Drawing.Size(77, 16);
            this.label_calColor.TabIndex = 32;
            this.label_calColor.Text = "FILE NAME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "MINIMUM:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "MAXIMUM:";
            // 
            // areaResult_max
            // 
            this.areaResult_max.AutoSize = true;
            this.areaResult_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaResult_max.Location = new System.Drawing.Point(97, 243);
            this.areaResult_max.Name = "areaResult_max";
            this.areaResult_max.Size = new System.Drawing.Size(43, 16);
            this.areaResult_max.TabIndex = 35;
            this.areaResult_max.Text = "50000";
            // 
            // checkBox_blobsLabel
            // 
            this.checkBox_blobsLabel.AutoSize = true;
            this.checkBox_blobsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_blobsLabel.Location = new System.Drawing.Point(166, 288);
            this.checkBox_blobsLabel.Name = "checkBox_blobsLabel";
            this.checkBox_blobsLabel.Size = new System.Drawing.Size(124, 22);
            this.checkBox_blobsLabel.TabIndex = 36;
            this.checkBox_blobsLabel.Text = "BLOBs LABEL";
            this.checkBox_blobsLabel.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 498);
            this.Controls.Add(this.checkBox_blobsLabel);
            this.Controls.Add(this.areaResult_max);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_calColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_calCam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.areaResult_min);
            this.Controls.Add(this.blobsArea);
            this.Controls.Add(this.labelCurrentPort);
            this.Controls.Add(this.labelCurrentIP);
            this.Controls.Add(this.label_morphValue);
            this.Controls.Add(this.trackBar_morph);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Detection";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_morph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar_morph;
        private System.Windows.Forms.Label label_morphValue;
        private System.Windows.Forms.Label labelCurrentPort;
        private System.Windows.Forms.Label labelCurrentIP;
        private System.Windows.Forms.Label blobsArea;
        private System.Windows.Forms.Label areaResult_min;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_calCam;
        private System.Windows.Forms.Label label_calColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label areaResult_max;
        private System.Windows.Forms.CheckBox checkBox_blobsLabel;
    }
}