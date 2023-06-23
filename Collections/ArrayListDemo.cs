using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public  class ArrayListDemo
    {
        public static void Demo()
        {

            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("shaik");
            list .Add(2);
            list .Add("ismail");
            list.Add(3);
            list.Add("demo");
            foreach (var i in list)
            {
                Console.WriteLine("list items : "+i);
            }
            list.Insert(0, "zero");
            list.Remove("shaik");
            list.RemoveAt(0);
            list.RemoveRange(0, 2);
            list.Clear();


            foreach (var i in list)
            {
                Console.WriteLine("new list items : " + i);
            }
            int itemsCount = list.Count;
            Console.WriteLine("itemsCount : " + itemsCount);


        }
    }
}
