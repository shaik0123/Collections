using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public  class HashTableDemo
    {
        public static void HashDemo()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "Student");
            ht.Add(2, "teacher");
            ht.Add(3, "parents");

           /* String name = ht[1].ToString();
            Console.WriteLine(name);*/

            IDictionaryEnumerator en = ht.GetEnumerator();
            while (en.MoveNext()) 
            {
                String str = en.Value.ToString();
                Console.WriteLine(str);
            }


        }
    }
}
