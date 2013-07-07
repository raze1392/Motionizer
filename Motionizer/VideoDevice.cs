using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing;

namespace Motionizer
{
    class VideoDevice
    {
        private FilterInfoCollection videoDevices = null;
        private VideoCaptureDeviceForm videoDeviceList = null;
        private VideoCaptureDevice videoSource = null;
        public bool deviceExist = false;
        private Motionizer appContext = null;

        public VideoDevice(Motionizer appContext)
        {
            this.appContext = appContext;
        }

        public List<FilterInfo> getCamList()
        {
            List<FilterInfo> cameras = new List<FilterInfo>();
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                videoDeviceList = new VideoCaptureDeviceForm();
                
                if (videoDevices.Count == 0)
                {
                    throw new ApplicationException();
                }
                deviceExist = true;

                foreach (FilterInfo device in videoDevices)
                {
                    cameras.Add(device);
                }
            }
            catch (ApplicationException)
            {
                deviceExist = false;
                cameras = null;
            }
            return cameras;
        }

        /// <summary>
        /// Closes the Current Video Source
        /// </summary>
        public void CloseVideoSource()
        {
            if (!(videoSource == null))
            {
                if (videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource = null;
                }
            }
        }

        public bool startVideoSource(int index)
        {
            if (deviceExist)
            {
                videoSource = new VideoCaptureDevice(videoDevices[index].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(videoFrameHandler);
                CloseVideoSource();
                videoSource.Start();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool stopVideoSource()
        {
            if (deviceExist)
            {
                if (videoSource.IsRunning)
                {
                    CloseVideoSource();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        private void videoFrameHandler(object sender, NewFrameEventArgs eventArgs)
        {
            appContext.frameProcessor((Bitmap)eventArgs.Frame.Clone());
        }
    }
}
