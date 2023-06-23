using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public  class DictionaryDemo
    {
        public static void Demo()
        {
            Dictionary<string,string> dic = new Dictionary<string,string>();
            dic.Add("one", "two");
            dic.Add("three", "four");
            dic.Add("five", "six");
            dic.Add("seven", "eight");

            foreach (var item in dic)
            {
                Console.WriteLine(item);

            }

        }
    }
}
