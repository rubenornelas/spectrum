namespace CTPro
{
    partial class Form2
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
                cam_test.Dispose();
                calWindow.Dispose();
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
            this.label_point4 = new System.Windows.Forms.Label();
            this.label_point3 = new System.Windows.Forms.Label();
            this.label_point2 = new System.Windows.Forms.Label();
            this.label_point1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button_addFile = new System.Windows.Forms.Button();
            this.textBox_fileName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_point1X = new System.Windows.Forms.TextBox();
            this.textBox_point1Y = new System.Windows.Forms.TextBox();
            this.textBox_point2Y = new System.Windows.Forms.TextBox();
            this.textBox_point2X = new System.Windows.Forms.TextBox();
            this.textBox_point3Y = new System.Windows.Forms.TextBox();
            this.textBox_point3X = new System.Windows.Forms.TextBox();
            this.textBox_point4Y = new System.Windows.Forms.TextBox();
            this.textBox_point4X = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorSquare = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_point4
            // 
            this.label_point4.AutoSize = true;
            this.label_point4.BackColor = System.Drawing.Color.AliceBlue;
            this.label_point4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_point4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_point4.Location = new System.Drawing.Point(24, 247);
            this.label_point4.Name = "label_point4";
            this.label_point4.Padding = new System.Windows.Forms.Padding(3);
            this.label_point4.Size = new System.Drawing.Size(62, 26);
            this.label_point4.TabIndex = 8;
            this.label_point4.Text = "Point 4";
            this.label_point4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_point4.Click += new System.EventHandler(this.label_point4_Click);
            // 
            // label_point3
            // 
            this.label_point3.AutoSize = true;
            this.label_point3.BackColor = System.Drawing.Color.AliceBlue;
            this.label_point3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_point3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_point3.Location = new System.Drawing.Point(24, 208);
            this.label_point3.Name = "label_point3";
            this.label_point3.Padding = new System.Windows.Forms.Padding(3);
            this.label_point3.Size = new System.Drawing.Size(62, 26);
            this.label_point3.TabIndex = 7;
            this.label_point3.Text = "Point 3";
            this.label_point3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_point3.Click += new System.EventHandler(this.label_point3_Click);
            // 
            // label_point2
            // 
            this.label_point2.AutoSize = true;
            this.label_point2.BackColor = System.Drawing.Color.AliceBlue;
            this.label_point2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_point2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_point2.Location = new System.Drawing.Point(24, 170);
            this.label_point2.Name = "label_point2";
            this.label_point2.Padding = new System.Windows.Forms.Padding(3);
            this.label_point2.Size = new System.Drawing.Size(62, 26);
            this.label_point2.TabIndex = 6;
            this.label_point2.Text = "Point 2";
            this.label_point2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_point2.Click += new System.EventHandler(this.label_point2_Click);
            // 
            // label_point1
            // 
            this.label_point1.AutoSize = true;
            this.label_point1.BackColor = System.Drawing.Color.AliceBlue;
            this.label_point1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_point1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_point1.Location = new System.Drawing.Point(24, 131);
            this.label_point1.Name = "label_point1";
            this.label_point1.Padding = new System.Windows.Forms.Padding(3);
            this.label_point1.Size = new System.Drawing.Size(62, 26);
            this.label_point1.TabIndex = 10;
            this.label_point1.Text = "Point 1";
            this.label_point1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_point1.Click += new System.EventHandler(this.label_point1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button_addFile
            // 
            this.button_addFile.Enabled = false;
            this.button_addFile.Location = new System.Drawing.Point(123, 308);
            this.button_addFile.Name = "button_addFile";
            this.button_addFile.Size = new System.Drawing.Size(94, 40);
            this.button_addFile.TabIndex = 13;
            this.button_addFile.Text = "SAVE FILE";
            this.button_addFile.UseVisualStyleBackColor = true;
            this.button_addFile.Click += new System.EventHandler(this.button_addFile_Click);
            // 
            // textBox_fileName
            // 
            this.textBox_fileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_fileName.Location = new System.Drawing.Point(102, 54);
            this.textBox_fileName.Name = "textBox_fileName";
            this.textBox_fileName.Size = new System.Drawing.Size(124, 26);
            this.textBox_fileName.TabIndex = 12;
            this.textBox_fileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(119, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "FILE NAME";
            // 
            // textBox_point1X
            // 
            this.textBox_point1X.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_point1X.Location = new System.Drawing.Point(95, 131);
            this.textBox_point1X.Name = "textBox_point1X";
            this.textBox_point1X.Size = new System.Drawing.Size(82, 26);
            this.textBox_point1X.TabIndex = 14;
            this.textBox_point1X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_point1Y
            // 
            this.textBox_point1Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_point1Y.Location = new System.Drawing.Point(183, 131);
            this.textBox_point1Y.Name = "textBox_point1Y";
            this.textBox_point1Y.Size = new System.Drawing.Size(82, 26);
            this.textBox_point1Y.TabIndex = 15;
            this.textBox_point1Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_point2Y
            // 
            this.textBox_point2Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_point2Y.Location = new System.Drawing.Point(183, 170);
            this.textBox_point2Y.Name = "textBox_point2Y";
            this.textBox_point2Y.Size = new System.Drawing.Size(82, 26);
            this.textBox_point2Y.TabIndex = 17;
            this.textBox_point2Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_point2X
            // 
            this.textBox_point2X.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_point2X.Location = new System.Drawing.Point(95, 170);
            this.textBox_point2X.Name = "textBox_point2X";
            this.textBox_point2X.Size = new System.Drawing.Size(82, 26);
            this.textBox_point2X.TabIndex = 16;
            this.textBox_point2X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_point3Y
            // 
            this.textBox_point3Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_point3Y.Location = new System.Drawing.Point(183, 208);
            this.textBox_point3Y.Name = "textBox_point3Y";
            this.textBox_point3Y.Size = new System.Drawing.Size(82, 26);
            this.textBox_point3Y.TabIndex = 19;
            this.textBox_point3Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_point3X
            // 
            this.textBox_point3X.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_point3X.Location = new System.Drawing.Point(95, 208);
            this.textBox_point3X.Name = "textBox_point3X";
            this.textBox_point3X.Size = new System.Drawing.Size(82, 26);
            this.textBox_point3X.TabIndex = 18;
            this.textBox_point3X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_point4Y
            // 
            this.textBox_point4Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_point4Y.Location = new System.Drawing.Point(183, 247);
            this.textBox_point4Y.Name = "textBox_point4Y";
            this.textBox_point4Y.Size = new System.Drawing.Size(82, 26);
            this.textBox_point4Y.TabIndex = 21;
            this.textBox_point4Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_point4X
            // 
            this.textBox_point4X.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_point4X.Location = new System.Drawing.Point(95, 247);
            this.textBox_point4X.Name = "textBox_point4X";
            this.textBox_point4X.Size = new System.Drawing.Size(82, 26);
            this.textBox_point4X.TabIndex = 20;
            this.textBox_point4X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Y";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // colorSquare
            // 
            this.colorSquare.AutoSize = true;
            this.colorSquare.BackColor = System.Drawing.Color.Red;
            this.colorSquare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorSquare.Location = new System.Drawing.Point(281, 137);
            this.colorSquare.Margin = new System.Windows.Forms.Padding(0);
            this.colorSquare.MaximumSize = new System.Drawing.Size(15, 15);
            this.colorSquare.MinimumSize = new System.Drawing.Size(15, 15);
            this.colorSquare.Name = "colorSquare";
            this.colorSquare.Size = new System.Drawing.Size(15, 15);
            this.colorSquare.TabIndex = 27;
            this.colorSquare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.MaximumSize = new System.Drawing.Size(15, 15);
            this.label3.MinimumSize = new System.Drawing.Size(15, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 28;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Aqua;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(281, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.MaximumSize = new System.Drawing.Size(15, 15);
            this.label4.MinimumSize = new System.Drawing.Size(15, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 29;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(281, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.MaximumSize = new System.Drawing.Size(15, 15);
            this.label6.MinimumSize = new System.Drawing.Size(15, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 15);
            this.label6.TabIndex = 30;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.colorSquare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_point4Y);
            this.Controls.Add(this.textBox_point4X);
            this.Controls.Add(this.textBox_point3Y);
            this.Controls.Add(this.textBox_point3X);
            this.Controls.Add(this.textBox_point2Y);
            this.Controls.Add(this.textBox_point2X);
            this.Controls.Add(this.textBox_point1Y);
            this.Controls.Add(this.textBox_point1X);
            this.Controls.Add(this.button_addFile);
            this.Controls.Add(this.textBox_fileName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_point1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_point4);
            this.Controls.Add(this.label_point3);
            this.Controls.Add(this.label_point2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form2";
            this.Text = "Camera Calibration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_point4;
        private System.Windows.Forms.Label label_point3;
        private System.Windows.Forms.Label label_point2;
        private System.Windows.Forms.Label label_point1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button_addFile;
        private System.Windows.Forms.TextBox textBox_fileName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_point1X;
        private System.Windows.Forms.TextBox textBox_point1Y;
        private System.Windows.Forms.TextBox textBox_point2Y;
        private System.Windows.Forms.TextBox textBox_point2X;
        private System.Windows.Forms.TextBox textBox_point3Y;
        private System.Windows.Forms.TextBox textBox_point3X;
        private System.Windows.Forms.TextBox textBox_point4Y;
        private System.Windows.Forms.TextBox textBox_point4X;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label colorSquare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}