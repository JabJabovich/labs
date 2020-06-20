using System;
using System.Collections.Generic;
using System.Text;

namespace _8._4
{
    class ArithmeticProgression : IProgression
    {
        private int a;
        private int d;
        public ArithmeticProgression(int a, int d)
        {
            this.a = a;
            this.d = d;
        }
        public int GetElement(int k)
        {
            return a + d * k;
        }
    }
}
