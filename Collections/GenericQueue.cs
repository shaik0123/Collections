using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collections
{
    public  class GenericQueue
    {
        public static void Demo()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("strong");
            queue.Enqueue("week");
            queue.Enqueue("normal");
            queue.Enqueue("dull");

            foreach (var item in queue) 
            {
                Console.WriteLine(item);
            }
        }
    }
}
