using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motionizer.Effects
{
    interface IMotionizerEffect
    {
        Bitmap processFrame(params Bitmap[] frame);
        int Threshold { get; set; }
    }

}
