using System;
using System.Collections.Generic;
using System.Text;

namespace Progression
{
    class GeometricProgression:Progression
    {
        private int b;
        private int q;
        public GeometricProgression(int b, int q)
        {
            this.b = b;
            this.q = q;
        }
        public override int GetElement(int k)
        {
            return b * (int)Math.Pow(q, k);
        }
    }
}
