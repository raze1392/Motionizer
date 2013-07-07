using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Motionizer.Effects;
using AForge.Imaging;
using AForge.Imaging.Filters;
using System.Drawing;

namespace Motionizer
{
    /// <summary>
    /// Detects motion by comparing currentFrame with previous Frame
    /// </summary>
    class MotionDetectorCompare : IMotionizerEffect
    {
        private int threshold_val;
        private Bitmap backgroundFrame;

        public MotionDetectorCompare(int threshold_val, Bitmap backgroundFrame = null)
        {
            this.threshold_val = threshold_val;
            this.backgroundFrame = backgroundFrame;
        }

        public int Threshold
        {
            get
            {
                return this.threshold_val;
            }
            set
            {
                this.threshold_val = value;
            }
        }

        public Bitmap BackgroundFrame
        {
            get
            {
                return this.backgroundFrame;
            }
        }

        /// <summary>
        /// processes Frame for Motion Detection based on frame comparison
        /// </summary>
        /// <param name="frame">
        /// Takes in 2 Bitmap parameters, currentFrame and backgroundFrame
        /// </param>
        /// <returns>
        /// frame in which motion is marked
        /// </returns>
        public Bitmap processFrame(params Bitmap[] frame)
        {
            Bitmap currentFrame = frame[0];
            // create grayscale filter (BT709)
            Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
            Bitmap GScurrentFrame = filter.Apply(currentFrame);
            if (this.backgroundFrame == null)
            {
                this.backgroundFrame = (Bitmap)GScurrentFrame.Clone();
                GScurrentFrame.Dispose();
                return currentFrame;
            }
            else
            {
                Difference differenceFilter = new Difference();
                IFilter thresholdFilter = new Threshold(15);
                // set backgroud frame as an overlay for difference filter
                differenceFilter.OverlayImage = backgroundFrame;
                Bitmap tmp = thresholdFilter.Apply(differenceFilter.Apply(GScurrentFrame));
                //reduce noise
                IFilter erosionFilter = new Erosion();
                Bitmap tmp1 = erosionFilter.Apply(tmp);
                tmp.Dispose();
                // Highlight Motions
                IFilter extractChannel = new ExtractChannel(RGB.G);
                Bitmap redChannel = extractChannel.Apply(currentFrame);
                Merge mergeFilter = new Merge();
                mergeFilter.OverlayImage = tmp1;
                Bitmap t3 = mergeFilter.Apply(redChannel);
                ReplaceChannel rc = new ReplaceChannel(RGB.G, t3);
                t3 = rc.Apply(currentFrame);
                this.backgroundFrame = (Bitmap)GScurrentFrame.Clone();
                redChannel.Dispose();
                tmp1.Dispose();
                GScurrentFrame.Dispose();
                return t3;
            }
        }
    }
}
