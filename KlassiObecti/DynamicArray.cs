using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassiObecti
{

    internal class DynamicArray
    {
        private List<int> list;
        private int count;

        public DynamicArray(int size)
        {
            if (size < 0)
            {
                throw new ArgumentOutOfRangeException("Размер массива не может быть отрицательным!");
            }
            this.list = new List<int>(size);
            this.count=size;
        }

        public DynamicArray()
        {
            this.list = new List<int>();
            this.count = 0;
        }

        public int Count {
            get { return list.Count; }
            set 
            { 
                if (value > 0 && value < list.Count)
                {
                    list.RemoveRange(value, list.Count - value);
                    count = value;
                }
                else if (value > list.Count)
                {
                    list.AddRange(new int[value-list.Count]);
                    count = value;
                }
            }
        }
        public void Print()
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }
        public void RandomFill()
        {
            Random rnd = new Random();
            for(int i=0; i < list.Count; i++)
            {
                list[i] = rnd.Next(10,20);
            }
            
        }
        public void Shuffle()
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                Random rnd = new Random();
                int j = rnd.Next(i + 1);
                int temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
        }
        public int DifCount()
        {
            int count = 0;
            for(int i=0; i < list.Count; i++)
            {
                for(int j=i+1; j<list.Count; j++)
                {
                    if (list[i] == list[j]) 
                    {
                        count++;
                        //Console.WriteLine(list[j]);
                    }
                    
                }

            }
            return list.Count-count;
        }
    }
}
