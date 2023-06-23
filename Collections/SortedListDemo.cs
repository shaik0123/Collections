using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public  class SortedListDemo
    {
        public static void Sorted()
        {
            SortedList<int, string> keyValuePairs = new SortedList<int, string>();
            keyValuePairs.Add(1, "movies");
            keyValuePairs.Add(2, "sports");
            keyValuePairs.Add(3, "events");
            keyValuePairs.Add(4, "programs");
            keyValuePairs.Add(5, "racing");
            keyValuePairs.Add(6, "riding");
            //keyValuePairs.Remove(3);

            foreach (KeyValuePair<int, string> pair in keyValuePairs)
            {
                Console.WriteLine(pair.Key+ " ===> "+ pair.Value);
            }
            Console.WriteLine("no of elements : "+keyValuePairs.Count);
           // Console.WriteLine("capacity : " + keyValuePairs.Capacity);
            keyValuePairs.Add(7, "seven");
            keyValuePairs.Add(8, "eight");
            keyValuePairs.Add(9, "nine");
            Console.WriteLine("no of elements after adding  : " + keyValuePairs.Count);
            //Console.WriteLine("after capacity : " + keyValuePairs.Capacity);


           // IList <int> list = keyValuePairs;
           Console.WriteLine("index 0f key 9 : "+keyValuePairs.IndexOfKey(9));
            Console.WriteLine("value 0f key riding : " + keyValuePairs.IndexOfValue("riding"));
            

        }

    }
}
