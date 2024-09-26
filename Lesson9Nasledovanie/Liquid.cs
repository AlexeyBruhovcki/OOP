using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9Nasledovanie
{
    internal class Liquid
    {
        public string? Name { get; set; }
        private int dencity;
        public int Dencity
        {
            get
            {
                return dencity;
            }
            set
            {
                if (value > 0) dencity = value;
                else throw new ArgumentException("Плотность должна быть положительной");
            }
        }

        public Liquid(string? name, int dencity)
        {
            Name = name;
            Dencity = dencity;
        }

        public int NewDencity(int dencity)
        {
            return Dencity=dencity;
            
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Название: {Name}, плотность: {dencity}");
        }
    }
}
