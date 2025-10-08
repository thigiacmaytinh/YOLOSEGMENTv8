using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TGMT; 

namespace YOLOSEGMENT
{
    public partial class Form1 : Form
    {
        YOLOv8Segmentor segmentor;

        public Form1()
        {
            InitializeComponent();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void Form1_Load(object sender, EventArgs e)
        {          

            workerLoading.RunWorkerAsync();



        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void workerLoading_DoWork(object sender, DoWorkEventArgs e)
        {
            string weightPath = Application.StartupPath + "\\card.onnx";
            string classesPath = Application.StartupPath + "\\card.names";
            segmentor = new YOLOv8Segmentor(weightPath, classesPath, 640, 640);

            segmentor.DrawPolygon = true;
            segmentor.DrawCorner = true;
            segmentor.DrawText = true;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void workerLoading_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btn_detect.Enabled = true;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_detect_Click(object sender, EventArgs e)
        {
            circle1.Visible = true;
            Thread t = new Thread(() => Detect());
            t.Start();            
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////


        void Detect()
        {
            
            string imagePath = Application.StartupPath + "\\2025-09-26.10-16-03_nDJYVBXPXa.jpg";
            Segmented segmented = segmentor.Segment(imagePath);

            this.Invoke(new Action(() =>
            {
                pictureBox1.Image = segmented.bitmap;
                this.Text = segmented.polygons.Length.ToString();

                circle1.Visible = false;
            }));            
        }
    }
}
