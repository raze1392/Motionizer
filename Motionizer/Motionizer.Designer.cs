namespace Motionizer
{
    partial class Motionizer
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
            this.PictureTabs = new System.Windows.Forms.TabControl();
            this.Org_Image_tab = new System.Windows.Forms.TabPage();
            this.Org_Image = new System.Windows.Forms.PictureBox();
            this.Lum_Image_tab = new System.Windows.Forms.TabPage();
            this.Lum_Image = new System.Windows.Forms.PictureBox();
            this.MotionDetec_Image_tab = new System.Windows.Forms.TabPage();
            this.MotionDetec_Image = new System.Windows.Forms.PictureBox();
            this.MotionDetecComp_Image_tab = new System.Windows.Forms.TabPage();
            this.MotionDetecComp_Image = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WebCam_List = new System.Windows.Forms.ListBox();
            this.Cam_Control = new System.Windows.Forms.Button();
            this.Refresh_List = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Lum_Value = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MotionDetec_Val = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.PictureTabs.SuspendLayout();
            this.Org_Image_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Org_Image)).BeginInit();
            this.Lum_Image_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lum_Image)).BeginInit();
            this.MotionDetec_Image_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MotionDetec_Image)).BeginInit();
            this.MotionDetecComp_Image_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MotionDetecComp_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lum_Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MotionDetec_Val)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureTabs
            // 
            this.PictureTabs.Controls.Add(this.Org_Image_tab);
            this.PictureTabs.Controls.Add(this.Lum_Image_tab);
            this.PictureTabs.Controls.Add(this.MotionDetec_Image_tab);
            this.PictureTabs.Controls.Add(this.MotionDetecComp_Image_tab);
            this.PictureTabs.Location = new System.Drawing.Point(12, 12);
            this.PictureTabs.Name = "PictureTabs";
            this.PictureTabs.SelectedIndex = 0;
            this.PictureTabs.Size = new System.Drawing.Size(668, 520);
            this.PictureTabs.TabIndex = 0;
            // 
            // Org_Image_tab
            // 
            this.Org_Image_tab.BackColor = System.Drawing.Color.Transparent;
            this.Org_Image_tab.Controls.Add(this.Org_Image);
            this.Org_Image_tab.Location = new System.Drawing.Point(4, 22);
            this.Org_Image_tab.Name = "Org_Image_tab";
            this.Org_Image_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Org_Image_tab.Size = new System.Drawing.Size(660, 494);
            this.Org_Image_tab.TabIndex = 0;
            this.Org_Image_tab.Text = "Video (Org)";
            // 
            // Org_Image
            // 
            this.Org_Image.Location = new System.Drawing.Point(9, 6);
            this.Org_Image.Name = "Org_Image";
            this.Org_Image.Size = new System.Drawing.Size(640, 480);
            this.Org_Image.TabIndex = 0;
            this.Org_Image.TabStop = false;
            // 
            // Lum_Image_tab
            // 
            this.Lum_Image_tab.BackColor = System.Drawing.Color.Transparent;
            this.Lum_Image_tab.Controls.Add(this.Lum_Image);
            this.Lum_Image_tab.Location = new System.Drawing.Point(4, 22);
            this.Lum_Image_tab.Name = "Lum_Image_tab";
            this.Lum_Image_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Lum_Image_tab.Size = new System.Drawing.Size(660, 494);
            this.Lum_Image_tab.TabIndex = 1;
            this.Lum_Image_tab.Text = "Luminance";
            // 
            // Lum_Image
            // 
            this.Lum_Image.Location = new System.Drawing.Point(9, 6);
            this.Lum_Image.Name = "Lum_Image";
            this.Lum_Image.Size = new System.Drawing.Size(640, 480);
            this.Lum_Image.TabIndex = 0;
            this.Lum_Image.TabStop = false;
            // 
            // MotionDetec_Image_tab
            // 
            this.MotionDetec_Image_tab.BackColor = System.Drawing.Color.Transparent;
            this.MotionDetec_Image_tab.Controls.Add(this.MotionDetec_Image);
            this.MotionDetec_Image_tab.Location = new System.Drawing.Point(4, 22);
            this.MotionDetec_Image_tab.Name = "MotionDetec_Image_tab";
            this.MotionDetec_Image_tab.Padding = new System.Windows.Forms.Padding(3);
            this.MotionDetec_Image_tab.Size = new System.Drawing.Size(660, 494);
            this.MotionDetec_Image_tab.TabIndex = 2;
            this.MotionDetec_Image_tab.Text = "Motion Detection";
            // 
            // MotionDetec_Image
            // 
            this.MotionDetec_Image.Location = new System.Drawing.Point(10, 7);
            this.MotionDetec_Image.Name = "MotionDetec_Image";
            this.MotionDetec_Image.Size = new System.Drawing.Size(640, 480);
            this.MotionDetec_Image.TabIndex = 1;
            this.MotionDetec_Image.TabStop = false;
            // 
            // MotionDetecComp_Image_tab
            // 
            this.MotionDetecComp_Image_tab.BackColor = System.Drawing.Color.Transparent;
            this.MotionDetecComp_Image_tab.Controls.Add(this.MotionDetecComp_Image);
            this.MotionDetecComp_Image_tab.Location = new System.Drawing.Point(4, 22);
            this.MotionDetecComp_Image_tab.Name = "MotionDetecComp_Image_tab";
            this.MotionDetecComp_Image_tab.Padding = new System.Windows.Forms.Padding(3);
            this.MotionDetecComp_Image_tab.Size = new System.Drawing.Size(660, 494);
            this.MotionDetecComp_Image_tab.TabIndex = 3;
            this.MotionDetecComp_Image_tab.Text = "Motion Det. Comparison";
            // 
            // MotionDetecComp_Image
            // 
            this.MotionDetecComp_Image.Location = new System.Drawing.Point(10, 7);
            this.MotionDetecComp_Image.Name = "MotionDetecComp_Image";
            this.MotionDetecComp_Image.Size = new System.Drawing.Size(640, 480);
            this.MotionDetecComp_Image.TabIndex = 2;
            this.MotionDetecComp_Image.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(697, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Motionizer";
            // 
            // WebCam_List
            // 
            this.WebCam_List.FormattingEnabled = true;
            this.WebCam_List.Location = new System.Drawing.Point(686, 150);
            this.WebCam_List.Name = "WebCam_List";
            this.WebCam_List.Size = new System.Drawing.Size(205, 30);
            this.WebCam_List.TabIndex = 2;
            this.WebCam_List.SelectedIndexChanged += new System.EventHandler(this.WebCam_List_SelectedIndexChanged);
            // 
            // Cam_Control
            // 
            this.Cam_Control.Location = new System.Drawing.Point(687, 187);
            this.Cam_Control.Name = "Cam_Control";
            this.Cam_Control.Size = new System.Drawing.Size(97, 30);
            this.Cam_Control.TabIndex = 3;
            this.Cam_Control.Text = "Start Capture";
            this.Cam_Control.UseVisualStyleBackColor = true;
            this.Cam_Control.Click += new System.EventHandler(this.Cam_Control_Click);
            // 
            // Refresh_List
            // 
            this.Refresh_List.Location = new System.Drawing.Point(790, 187);
            this.Refresh_List.Name = "Refresh_List";
            this.Refresh_List.Size = new System.Drawing.Size(101, 30);
            this.Refresh_List.TabIndex = 4;
            this.Refresh_List.Text = "Refresh List";
            this.Refresh_List.UseVisualStyleBackColor = true;
            this.Refresh_List.Click += new System.EventHandler(this.Refresh_List_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(687, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Luminance Settings";
            // 
            // Lum_Value
            // 
            this.Lum_Value.Location = new System.Drawing.Point(687, 252);
            this.Lum_Value.Maximum = 255;
            this.Lum_Value.Name = "Lum_Value";
            this.Lum_Value.Size = new System.Drawing.Size(204, 45);
            this.Lum_Value.TabIndex = 6;
            this.Lum_Value.TickFrequency = 5;
            this.Lum_Value.Value = 225;
            this.Lum_Value.ValueChanged += new System.EventHandler(this.Lum_Value_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(694, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(872, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "255";
            this.label4.UseMnemonic = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(687, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Threshold value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(872, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "100";
            this.label6.UseMnemonic = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(694, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "0";
            // 
            // MotionDetec_Val
            // 
            this.MotionDetec_Val.Location = new System.Drawing.Point(687, 320);
            this.MotionDetec_Val.Maximum = 100;
            this.MotionDetec_Val.Name = "MotionDetec_Val";
            this.MotionDetec_Val.Size = new System.Drawing.Size(204, 45);
            this.MotionDetec_Val.TabIndex = 10;
            this.MotionDetec_Val.TickFrequency = 5;
            this.MotionDetec_Val.Value = 20;
            this.MotionDetec_Val.ValueChanged += new System.EventHandler(this.MotionDetec_Val_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(819, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Shivam";
            // 
            // Motionizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 543);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MotionDetec_Val);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lum_Value);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Refresh_List);
            this.Controls.Add(this.Cam_Control);
            this.Controls.Add(this.WebCam_List);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureTabs);
            this.Name = "Motionizer";
            this.Text = "Motionizer";
            this.PictureTabs.ResumeLayout(false);
            this.Org_Image_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Org_Image)).EndInit();
            this.Lum_Image_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Lum_Image)).EndInit();
            this.MotionDetec_Image_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MotionDetec_Image)).EndInit();
            this.MotionDetecComp_Image_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MotionDetecComp_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lum_Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MotionDetec_Val)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl PictureTabs;
        private System.Windows.Forms.TabPage Org_Image_tab;
        private System.Windows.Forms.PictureBox Org_Image;
        private System.Windows.Forms.TabPage Lum_Image_tab;
        private System.Windows.Forms.PictureBox Lum_Image;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox WebCam_List;
        private System.Windows.Forms.Button Cam_Control;
        private System.Windows.Forms.Button Refresh_List;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar Lum_Value;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar MotionDetec_Val;
        private System.Windows.Forms.TabPage MotionDetec_Image_tab;
        private System.Windows.Forms.PictureBox MotionDetec_Image;
        private System.Windows.Forms.TabPage MotionDetecComp_Image_tab;
        private System.Windows.Forms.PictureBox MotionDetecComp_Image;
        private System.Windows.Forms.Label label8;
    }
}

