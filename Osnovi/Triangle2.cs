using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Osnovi
{
    struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y)
        {
            X= x;
            Y= y;
        }
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
    internal class Triangle2
    {
        private Point A;
        private Point B; 
        private Point C;
        public Triangle2(Point a, Point b, Point c)
        {
            if (Valid(a,b,c))
            { 
            this.A = a;
            this.B = b;
            this.C = c; 
            }
            else throw new Exception("Неверные координаты");
        }
        public void PrintState()
        {
            Console.WriteLine($"Точка A: {A}");
            Console.WriteLine($"Точка B: {B}");
            Console.WriteLine($"Точка B: {C}");
            Console.WriteLine($"Сторона AB: {SideLenght(A, B):F2}");
            Console.WriteLine($"Сторона BC: {SideLenght(B, C):F2}");
            Console.WriteLine($"Сторона CA: {SideLenght(C, A):F2}");
            Console.WriteLine($"Площадь: {Area():F2}");
            Console.WriteLine($"Периметр: {Perimetr():F2}");
            Console.WriteLine($"Координаты точки пересечения медиан: {Centroid(A,B,C)}");
        }
        public double SideLenght(Point P1,Point P2)
        {
            return Math.Sqrt((P2.X - P1.X) * (P2.X - P1.X) + (P2.Y - P1.Y) * (P2.Y - P1.Y));
        }
        public bool Valid(Point _a,Point _b,Point _c)
        {
            if(SideLenght(_a,_b)+ SideLenght(_b, _c)> SideLenght(_c, _a)&& SideLenght(_a, _b) + SideLenght(_c, _a) > SideLenght(_b, _c)&& SideLenght(_c, _a) + SideLenght(_b, _c) > SideLenght(_a, _b)) { return true; }
            return false;
        }
        public double Perimetr()
        {
            return SideLenght(A,B)+SideLenght(B,C)+SideLenght(C,A);
        }
        public double Area()
        {
            double pp=Perimetr()/2;
            return Math.Sqrt(pp * (pp - SideLenght(A, B)) * (pp - SideLenght(B, C)) * (pp - SideLenght(C, A)));
        }
        public Point Centroid(Point A,Point B,Point C)
        {
            double xCentr;
            double yCentr;
            xCentr=Math.Round((A.X+B.X+C.X)/3,2);
            yCentr=Math.Round((A.Y+B.Y+C.Y)/3,2);
            return new Point(xCentr, yCentr);
        }
    }
}
