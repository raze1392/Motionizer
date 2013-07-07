using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Motionizer.Effects;

namespace Motionizer
{
    /// <summary>
    /// Holds all the effects that can be applied at bulk
    /// </summary>
    class MotionizerEffectList : IEnumerable
    {
        private List<IMotionizerEffect> _effects = null;
        
        public MotionizerEffectList()
        {
            this._effects = new List<IMotionizerEffect>();
        }

        public MotionizerEffectList(params IMotionizerEffect[] effects)
        {
            this._effects = new List<IMotionizerEffect>();

            foreach (IMotionizerEffect effect in effects)
            {
                this._effects.Add(effect);
            }
        }

        public int Count
        {
            get
            {
                return this._effects.Count;
            }
        }

        public void Add(IMotionizerEffect effect)
        {
            this._effects.Add(effect);
        }

        public void Clear()
        {
            this._effects.Clear();
        }

        public IEnumerator GetEnumerator()
        {
            return this._effects.GetEnumerator();
        }
    }
}
