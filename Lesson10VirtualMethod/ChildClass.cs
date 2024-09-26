using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10VirtualMethod
{
    internal class ChildClass:BaseClass
    {
        public int SecNumber;
        public int this[int index1,int index2] //index1: 0-поле базового класса,
                                               //1(или друое значение) - поле класса потомка
                                               //index2 разряд числа: 0 - единицы, 1- десятки и тд.
        {
            get
            {
                int field;
                if (index1 == 0) field = Number;
                else field=SecNumber;
                return (field / (int)Math.Pow(10, index2)) % 10; //вовзращаем цифру
            }
        }
        public override int this[int index]
        {
            get 
            {
                string strNumber = (Number+SecNumber).ToString(); //выбор цифры числа по индексу 
                                                                  //слева направо 0..n(index)
                return int.Parse(strNumber[index].ToString()); 
            }
               
        }


    }
}
