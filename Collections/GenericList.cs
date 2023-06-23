using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class GenericList
    {
        public static void Demo()
        {
            List<string> list = new List<string>();
            list.Add("ab");
            list.Add("bc");
            list.Add("cd");
            list.Add("de");
            list.Add("aa");

            foreach (string item in list) 
            {
            Console.WriteLine(item);
            }
            

        }
    }
}
