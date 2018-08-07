namespace CTPro
{
    partial class Form4
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
                colourWindow.Dispose();
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar_smin = new System.Windows.Forms.TrackBar();
            this.trackBar_smax = new System.Windows.Forms.TrackBar();
            this.trackBar_vmin = new System.Windows.Forms.TrackBar();
            this.trackBar_vmax = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_smin = new System.Windows.Forms.Label();
            this.label_smax = new System.Windows.Forms.Label();
            this.label_vmin = new System.Windows.Forms.Label();
            this.label_vmax = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_smin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_smax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_vmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_vmax)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "BLOBS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(206, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "REAL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(272, 411);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "DONE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "FILE NAME:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(135, 354);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 23);
            this.textBox1.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(154, 383);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "ADD Colour";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "# 0";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(19, 411);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 41);
            this.button5.TabIndex = 7;
            this.button5.Text = "BACK";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar_smin
            // 
            this.trackBar_smin.Location = new System.Drawing.Point(1, 86);
            this.trackBar_smin.Maximum = 255;
            this.trackBar_smin.Name = "trackBar_smin";
            this.trackBar_smin.Size = new System.Drawing.Size(383, 45);
            this.trackBar_smin.TabIndex = 8;
            // 
            // trackBar_smax
            // 
            this.trackBar_smax.Location = new System.Drawing.Point(1, 152);
            this.trackBar_smax.Maximum = 255;
            this.trackBar_smax.Name = "trackBar_smax";
            this.trackBar_smax.Size = new System.Drawing.Size(383, 45);
            this.trackBar_smax.TabIndex = 9;
            this.trackBar_smax.Value = 255;
            // 
            // trackBar_vmin
            // 
            this.trackBar_vmin.Location = new System.Drawing.Point(1, 217);
            this.trackBar_vmin.Maximum = 255;
            this.trackBar_vmin.Name = "trackBar_vmin";
            this.trackBar_vmin.Size = new System.Drawing.Size(383, 45);
            this.trackBar_vmin.TabIndex = 10;
            // 
            // trackBar_vmax
            // 
            this.trackBar_vmax.Location = new System.Drawing.Point(1, 287);
            this.trackBar_vmax.Maximum = 255;
            this.trackBar_vmax.Name = "trackBar_vmax";
            this.trackBar_vmax.Size = new System.Drawing.Size(383, 45);
            this.trackBar_vmax.TabIndex = 11;
            this.trackBar_vmax.Value = 255;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "SATURATION Min:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "SATURATION Max:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "VALUE Min:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "VALUE Max:";
            // 
            // label_smin
            // 
            this.label_smin.AutoSize = true;
            this.label_smin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_smin.Location = new System.Drawing.Point(142, 66);
            this.label_smin.Name = "label_smin";
            this.label_smin.Size = new System.Drawing.Size(16, 17);
            this.label_smin.TabIndex = 20;
            this.label_smin.Text = "0";
            // 
            // label_smax
            // 
            this.label_smax.AutoSize = true;
            this.label_smax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_smax.Location = new System.Drawing.Point(142, 132);
            this.label_smax.Name = "label_smax";
            this.label_smax.Size = new System.Drawing.Size(16, 17);
            this.label_smax.TabIndex = 21;
            this.label_smax.Text = "0";
            // 
            // label_vmin
            // 
            this.label_vmin.AutoSize = true;
            this.label_vmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vmin.Location = new System.Drawing.Point(142, 197);
            this.label_vmin.Name = "label_vmin";
            this.label_vmin.Size = new System.Drawing.Size(16, 17);
            this.label_vmin.TabIndex = 22;
            this.label_vmin.Text = "0";
            // 
            // label_vmax
            // 
            this.label_vmax.AutoSize = true;
            this.label_vmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vmax.Location = new System.Drawing.Point(142, 267);
            this.label_vmax.Name = "label_vmax";
            this.label_vmax.Size = new System.Drawing.Size(16, 17);
            this.label_vmax.TabIndex = 23;
            this.label_vmax.Text = "0";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.label_vmax);
            this.Controls.Add(this.label_vmin);
            this.Controls.Add(this.label_smax);
            this.Controls.Add(this.label_smin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar_vmax);
            this.Controls.Add(this.trackBar_vmin);
            this.Controls.Add(this.trackBar_smax);
            this.Controls.Add(this.trackBar_smin);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_smin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_smax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_vmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_vmax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar_smin;
        private System.Windows.Forms.TrackBar trackBar_smax;
        private System.Windows.Forms.TrackBar trackBar_vmin;
        private System.Windows.Forms.TrackBar trackBar_vmax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_smin;
        private System.Windows.Forms.Label label_smax;
        private System.Windows.Forms.Label label_vmin;
        private System.Windows.Forms.Label label_vmax;
    }
}