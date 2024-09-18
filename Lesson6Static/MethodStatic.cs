using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6Static
{
    internal class MethodStatic
    {
        private int[] mas;
        
        public MethodStatic(int n)
        {
            this.mas = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(100);
            }
        }
        public int[] Mas
        {
            get { return mas; }
        }
        //public  int[] CreatIntMas(int n)
        //{
        //    Random r = new Random();
        //    int[] mas = new int[n];
        //    for (int i = 0; i < n; i++)
        //    {
        //        mas[i] = r.Next(100);
        //    }
        //    return mas;
        //}
        public  void PrintMas()
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i]+" ");
            }
            Console.WriteLine();
        }
        
        public static double Avg(int[] mas1)
        {
            int sum = 0;
            for (int i = 0; i < mas1.Length; i++)
            {
                sum += mas1[i];
            }
            return sum/mas1.Length;
        }
    }
}
