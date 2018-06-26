namespace Kinematics
{
    partial class MainForm
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
            this.pictureCube = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtXTheta = new System.Windows.Forms.TextBox();
            this.txtYTheta = new System.Windows.Forms.TextBox();
            this.txtZTheta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarX = new System.Windows.Forms.TrackBar();
            this.trackBarY = new System.Windows.Forms.TrackBar();
            this.trackBarZ = new System.Windows.Forms.TrackBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureCube
            // 
            this.pictureCube.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureCube.Location = new System.Drawing.Point(17, 16);
            this.pictureCube.Margin = new System.Windows.Forms.Padding(4);
            this.pictureCube.Name = "pictureCube";
            this.pictureCube.Size = new System.Drawing.Size(552, 292);
            this.pictureCube.TabIndex = 0;
            this.pictureCube.TabStop = false;
            this.pictureCube.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureCube_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtXTheta
            // 
            this.txtXTheta.BackColor = System.Drawing.Color.IndianRed;
            this.txtXTheta.Location = new System.Drawing.Point(287, 326);
            this.txtXTheta.Margin = new System.Windows.Forms.Padding(4);
            this.txtXTheta.Name = "txtXTheta";
            this.txtXTheta.ReadOnly = true;
            this.txtXTheta.Size = new System.Drawing.Size(75, 22);
            this.txtXTheta.TabIndex = 1;
            this.txtXTheta.Text = "0";
            // 
            // txtYTheta
            // 
            this.txtYTheta.BackColor = System.Drawing.Color.SteelBlue;
            this.txtYTheta.Location = new System.Drawing.Point(287, 358);
            this.txtYTheta.Margin = new System.Windows.Forms.Padding(4);
            this.txtYTheta.Name = "txtYTheta";
            this.txtYTheta.ReadOnly = true;
            this.txtYTheta.Size = new System.Drawing.Size(75, 22);
            this.txtYTheta.TabIndex = 2;
            this.txtYTheta.Text = "0";
            // 
            // txtZTheta
            // 
            this.txtZTheta.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtZTheta.Location = new System.Drawing.Point(287, 391);
            this.txtZTheta.Margin = new System.Windows.Forms.Padding(4);
            this.txtZTheta.Name = "txtZTheta";
            this.txtZTheta.ReadOnly = true;
            this.txtZTheta.Size = new System.Drawing.Size(75, 22);
            this.txtZTheta.TabIndex = 3;
            this.txtZTheta.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 330);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 362);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 395);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Z";
            // 
            // trackBarX
            // 
            this.trackBarX.LargeChange = 15;
            this.trackBarX.Location = new System.Drawing.Point(17, 326);
            this.trackBarX.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarX.Maximum = 360;
            this.trackBarX.Name = "trackBarX";
            this.trackBarX.Size = new System.Drawing.Size(225, 56);
            this.trackBarX.SmallChange = 5;
            this.trackBarX.TabIndex = 7;
            this.trackBarX.TickFrequency = 30;
            this.trackBarX.Scroll += new System.EventHandler(this.trackBarX_Scroll);
            // 
            // trackBarY
            // 
            this.trackBarY.LargeChange = 15;
            this.trackBarY.Location = new System.Drawing.Point(17, 358);
            this.trackBarY.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarY.Maximum = 360;
            this.trackBarY.Name = "trackBarY";
            this.trackBarY.Size = new System.Drawing.Size(225, 56);
            this.trackBarY.SmallChange = 5;
            this.trackBarY.TabIndex = 8;
            this.trackBarY.TickFrequency = 30;
            this.trackBarY.Scroll += new System.EventHandler(this.trackBarY_Scroll);
            // 
            // trackBarZ
            // 
            this.trackBarZ.LargeChange = 15;
            this.trackBarZ.Location = new System.Drawing.Point(17, 391);
            this.trackBarZ.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarZ.Maximum = 360;
            this.trackBarZ.Name = "trackBarZ";
            this.trackBarZ.Size = new System.Drawing.Size(225, 56);
            this.trackBarZ.SmallChange = 5;
            this.trackBarZ.TabIndex = 9;
            this.trackBarZ.TickFrequency = 30;
            this.trackBarZ.Scroll += new System.EventHandler(this.trackBarZ_Scroll);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(58, 36);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 21);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Spin?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(388, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 88);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cube Options";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 439);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trackBarZ);
            this.Controls.Add(this.trackBarY);
            this.Controls.Add(this.trackBarX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtZTheta);
            this.Controls.Add(this.txtYTheta);
            this.Controls.Add(this.txtXTheta);
            this.Controls.Add(this.pictureCube);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "3D Cube Rotation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureCube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureCube;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtXTheta;
        private System.Windows.Forms.TextBox txtYTheta;
        private System.Windows.Forms.TextBox txtZTheta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarX;
        private System.Windows.Forms.TrackBar trackBarY;
        private System.Windows.Forms.TrackBar trackBarZ;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

