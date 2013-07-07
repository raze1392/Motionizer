using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Motionizer.Effects;
using AForge.Imaging;
using AForge.Imaging.Filters;
using System.Drawing;

namespace Motionizer.Effects
{
    class MotionDetector : IMotionizerEffect
    {
        private int threshold_val;
        private Bitmap backgroundFrame;

        public MotionDetector(int threshold_val, Bitmap backgroundFrame = null)
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
        /// processes Frame for Motion Detection based on background generation
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
                Morph filterx = new Morph(GScurrentFrame);
                filterx.SourcePercent = 0.75;
                Bitmap tmp = filterx.Apply(backgroundFrame);
                // dispose old background
                backgroundFrame.Dispose();
                backgroundFrame = tmp;

                // create processing filters sequence
                FiltersSequence processingFilter = new FiltersSequence();
                processingFilter.Add(new Difference(backgroundFrame));
                processingFilter.Add(new Threshold(threshold_val));
                processingFilter.Add(new Opening());
                processingFilter.Add(new Edges());
                // apply the filter
                Bitmap tmp1 = processingFilter.Apply(GScurrentFrame);

                IFilter extractChannel = new ExtractChannel(RGB.R);
                Bitmap redChannel = extractChannel.Apply(currentFrame);
                Merge mergeFilter = new Merge();
                mergeFilter.OverlayImage = tmp1;
                Bitmap t3 = mergeFilter.Apply(redChannel);
                ReplaceChannel rc = new ReplaceChannel(RGB.R, t3);
                t3 = rc.Apply(currentFrame);
                redChannel.Dispose();
                tmp1.Dispose();
                GScurrentFrame.Dispose();
                return t3;
            }
        }

    }
}
