using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public  class Operations
    {
        public static void Operation()
        {
            int start = 1;
            int end = 7;
            ArrayList arrayList = new ArrayList();
            while (start <= end) { 
            Random random = new Random();
            int r = random.Next(0,7);
                arrayList.Add(r);
                start++;
            }
            foreach (int i in arrayList) 
            {
                Console.WriteLine(i);
               // Console.WriteLine(arrayList.Sort());
            }
            arrayList.Sort();
            foreach (int i in arrayList)
            {
                Console.Write("  "+i);
                
            }
            Console.WriteLine();
            Console.Write("searching element : " + arrayList.Contains(2));
            Console.WriteLine();

        }
    }
}
