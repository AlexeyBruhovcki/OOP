using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6Static
{
    internal class CharStatic
    {
        private char[] chars;
        public char[] Chars
        {
            get { return chars; }
        }

        public CharStatic(int n)
        {
            if (n % 2 == 0)
            {
                this.chars = new char[n];
                Random r = new Random();
                for (int i = 0; i < n; i++)
                {
                    if(r.Next(0, 2)==0) chars[i] = (char)r.Next(65,91);
                    else chars[i] = (char)r.Next(97, 123);
                }
            }
            else throw new ArgumentException("Размер массива должен быть четным числом");
            
        }
        public void PrintMas()
        {
            for (int i = 0; i < chars.Length; i++)
            {
                Console.Write(chars[i] + " ");
            }
            Console.WriteLine();
        }
        public static void PrintMas(char[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
        }
        public static char[] PairSwap(char[] a)
        {
            int j = a.Length - 1;
            for (int i=0; i<a.Length/2; i++)
            {
                
                (a[i], a[j]) = (a[j], a[i]);
                j--;
            }
            return a;
        }
    }
}
