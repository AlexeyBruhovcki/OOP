using System;
using System.Collections;
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

        public MassOfStrings()
        {
            this.stringList = new List<string>();
            this.count = 0;
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
        public void Print()
        {
            foreach (string item in stringList)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine( );
        }
        public static MassOfStrings DistinctList(MassOfStrings list)
        {
            List<string> distinctStrings = new List<string>();
            distinctStrings=list.stringList.Distinct().ToList();
            MassOfStrings distinctList=new MassOfStrings(distinctStrings.Count);
            distinctList.stringList=distinctStrings;
            return distinctList;
        }
        public static MassOfStrings MergeDistinct(MassOfStrings list1, MassOfStrings list2)
        {
            MassOfStrings mergeList= new MassOfStrings(list1.count+list2.count);
            for (int i = 0; i < list1.count; i++)
            {
                
                mergeList.Add(list1[i]);
            }
            for (int i = 0; i < list1.count; i++)
            {
                
                mergeList.Add(list2[i]);
            }
            mergeList = DistinctList(mergeList);
            return mergeList;
        }
        public static MassOfStrings Merge(MassOfStrings list1, MassOfStrings list2)
        {
            MassOfStrings mergeList = new MassOfStrings(list1.count + list2.count);
            for (int i = 0; i < list1.count; i++)
            {

                mergeList.Add(list1[i]);
            }
            for (int i = 0; i < list1.count; i++)
            {

                mergeList.Add(list2[i]);
            }
            
            return mergeList;
        }
    }
}
