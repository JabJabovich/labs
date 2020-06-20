using System;
using System.Collections.Generic;
using System.Text;

namespace Progression
{
    class ArithmeticProgression : Progression
    {
        private int a;
        private int d;
        public ArithmeticProgression(int a, int d)
        {
            this.a = a;
            this.d = d;
        }
        public override int GetElement(int k)
        {
            return a + d * k;
        }
    }
}
