namespace YOLOSEGMENT
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.workerLoading = new System.ComponentModel.BackgroundWorker();
            this.btn_detect = new TGMTcontrols.DefaultButton();
            this.circle1 = new TGMTcontrols.ProcessingControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(966, 436);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.circle1);
            this.panel1.Controls.Add(this.btn_detect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 168);
            this.panel1.TabIndex = 1;
            // 
            // workerLoading
            // 
            this.workerLoading.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerLoading_DoWork);
            this.workerLoading.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerLoading_RunWorkerCompleted);
            // 
            // btn_detect
            // 
            this.btn_detect.Active1 = System.Drawing.Color.DodgerBlue;
            this.btn_detect.Active2 = System.Drawing.Color.DeepSkyBlue;
            this.btn_detect.BackColor = System.Drawing.Color.Transparent;
            this.btn_detect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_detect.Enabled = false;
            this.btn_detect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_detect.ForeColor = System.Drawing.Color.White;
            this.btn_detect.Icon = null;
            this.btn_detect.ImageLocation = new System.Drawing.Point(0, 0);
            this.btn_detect.ImageSize = new System.Drawing.Size(0, 0);
            this.btn_detect.Inactive1 = System.Drawing.Color.DeepSkyBlue;
            this.btn_detect.Inactive2 = System.Drawing.Color.DodgerBlue;
            this.btn_detect.Location = new System.Drawing.Point(389, 54);
            this.btn_detect.Name = "btn_detect";
            this.btn_detect.Radius = 6;
            this.btn_detect.Size = new System.Drawing.Size(110, 30);
            this.btn_detect.Stroke = false;
            this.btn_detect.StrokeColor = System.Drawing.Color.Gray;
            this.btn_detect.TabIndex = 0;
            this.btn_detect.Text = "Detect";
            this.btn_detect.Transparency = false;
            this.btn_detect.Click += new System.EventHandler(this.btn_detect_Click);
            // 
            // circle1
            // 
            this.circle1.BackColor = System.Drawing.Color.Transparent;
            this.circle1.IndexColor = System.Drawing.Color.DeepSkyBlue;
            this.circle1.Interval = 50;
            this.circle1.Location = new System.Drawing.Point(521, 43);
            this.circle1.Name = "circle1";
            this.circle1.NCircle = 8;
            this.circle1.Others = System.Drawing.Color.LightGray;
            this.circle1.Radius = 4;
            this.circle1.Size = new System.Drawing.Size(40, 40);
            this.circle1.TabIndex = 1;
            this.circle1.Text = "processingControl1";
            this.circle1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 604);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker workerLoading;
        private TGMTcontrols.DefaultButton btn_detect;
        private TGMTcontrols.ProcessingControl circle1;
    }
}

