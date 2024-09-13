using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Indexatori
{

    internal class MassOfStrings
    {
        private List<string> stringList;
        private int count;

        public MassOfStrings(int count)
        {
            this.count = count;
            this.stringList = new List<string>(count);
            //for (int i = 0; i < count; i++)
            //{
            //    Console.Write("Введите строку: ");
            //    stringList.Add(Console.ReadLine()!);
            //}
        }
        public string this[int index]
        {
            get {if (index >= 0 && index < count) return stringList[index];
                else return null;
            }
            set { stringList[index] = value; }
        }
        public void Add(string value)
        {
            stringList.Add(value);
        }
        public void AddList(List<string> list)
        {
            stringList.AddRange(list);
        }

    }
}
