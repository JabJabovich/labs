using _8._4;
using System;
using System.Collections.Generic;
using System.Text;

namespace _8._4
{
    class GeometricProgression : IProgression
    {
        private int b;
        private int q;
        public GeometricProgression(int b, int q)
        {
            this.b = b;
            this.q = q;
        }
        public int GetElement(int k)
        {
            return b * (int)Math.Pow(q, k);
        }
    }
}
