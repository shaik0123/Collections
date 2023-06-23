using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public  class GenericSortedList
    {
        public static void Demo()
        {
            SortedList<int ,string> sortList = new SortedList<int ,string>();
            sortList.Add(1, "one");
            sortList.Add(2, "two");
            sortList.Add(3, "thrww");
            sortList.Add(4, "four");

            foreach(var i in sortList) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
