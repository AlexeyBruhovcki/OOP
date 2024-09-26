using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9Nasledovanie
{
    internal class Alcohol:Liquid
    {
        private double strength;
        public double Strength
        {
            get => strength;
            set
            {
                if(value>=0&&value<=100) strength = value;
                else throw new ArgumentException("Крепость должна быть больше или равна 0 и меньше 100");
            }
        }

        public Alcohol(string? name, int dencity, double strength) : base(name, dencity)
        {
            Strength = strength;
        }
        public double NewStrength(double strength)
        {
            return Strength= strength;
        }
        public override void PrintInfo()
        {
            //base.PrintInfo();
            //Console.WriteLine($"крепость: {strength}");
            Console.WriteLine($"Название: {Name}, плотность: {Dencity}, крепость: {strength}");
        }

       
    }
}
