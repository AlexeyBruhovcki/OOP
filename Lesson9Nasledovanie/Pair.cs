using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9Nasledovanie
{
    internal class Pair
    {
        public double A {  get; set; }
        public double B { get; set; }

        public Pair(double a, double b)
        {
            A = a;
            B = b;
        }
        public double Multi()
        {
            return A * B;
        }
        
    }
}
