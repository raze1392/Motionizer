using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using AForge.Video;
using AForge.Video.DirectShow;
using Motionizer.Effects;

namespace Motionizer
{
    public partial class Motionizer : Form
    {
        private MotionizerEffectList effects = new MotionizerEffectList();
        private VideoDevice driver;

        public Motionizer()
        {
            InitializeComponent();
            driver = new VideoDevice(this);
            getCameraList();
            effects.Add(new LuminanceDetector(Lum_Value.Value));
            effects.Add(new MotionDetector(MotionDetec_Val.Value));
            effects.Add(new MotionDetectorCompare(MotionDetec_Val.Value));
        }

        private void Cam_Control_Click(object sender, EventArgs e)
        {
            if (Cam_Control.Text == "Start Capture")
            {
                if (driver.startVideoSource(WebCam_List.SelectedIndex))
                {
                    Cam_Control.Text = "Stop Capture";
                }
            }
            else
            {
                if (driver.stopVideoSource())
                {
                    Cam_Control.Text = "Start Capture";
                }
            }
        }

        private void Refresh_List_Click(object sender, EventArgs e)
        {
            getCameraList();
        }

        /// <summary>
        /// Get the list of video devices
        /// </summary>
        private void getCameraList()
        {
            WebCam_List.Items.Clear();
            List<FilterInfo> cameras = driver.getCamList();
            foreach (FilterInfo camera in cameras)
            {
                WebCam_List.Items.Add(camera.Name);
            }
            WebCam_List.SelectedIndex = 0;
        }

        public void frameProcessor(Bitmap currentFrame)
        {
            foreach (IMotionizerEffect effect in this.effects)
            {
                Bitmap processedFrame = effect.processFrame(currentFrame);
                if (effect is IMotionizerEffect)
                {
                    if (effect is LuminanceDetector)
                    {
                        Lum_Image.Image = processedFrame;
                    }
                    else if (effect is MotionDetector)
                    {
                        MotionDetec_Image.Image = processedFrame;
                    }
                    else if (effect is MotionDetectorCompare)
                    {
                        MotionDetecComp_Image.Image = processedFrame;
                    }
                }
            }
            Org_Image.Image = currentFrame;
        }

        private void Lum_Value_ValueChanged(object sender, EventArgs e)
        {
            foreach (IMotionizerEffect effect in this.effects)
            {
                if (effect is LuminanceDetector)
                {
                    effect.Threshold = Lum_Value.Value;
                }
            }
        }

        private void MotionDetec_Val_ValueChanged(object sender, EventArgs e)
        {
            foreach (IMotionizerEffect effect in this.effects)
            {
                if (effect is MotionDetector || effect is MotionDetectorCompare)
                {
                    effect.Threshold = MotionDetec_Val.Value;
                }
            }
        }

        private void WebCam_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (driver.stopVideoSource())
            {
                driver.startVideoSource(WebCam_List.SelectedIndex);
            }*/
        }

        /*
        DllImport("gdi32")]
        static extern int DeleteObject(IntPtr o);

        public static BitmapSource loadBitmap(Bitmap source)
        {
            Console.Write("{0}, {1}, {2}", source.Width, source.Height, source.ToString());
            IntPtr ip = source.GetHbitmap();
            BitmapSource bs = null;
            try
            {
                bs = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(ip,
                   IntPtr.Zero, Int32Rect.Empty,
                   System.Windows.Media.Imaging.BitmapSizeOptions.FromEmptyOptions());
            }
            finally
            {
                DeleteObject(ip);
            }

            return bs;
        }
        */
    }
}
