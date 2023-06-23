using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public  class QueueDemo
    {
        public static void DemoQ()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue("name");
            queue.Enqueue('a') ;
            queue.Enqueue(4);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            queue.Dequeue();
           // queue.Clear();
            Console.WriteLine("//////////////////////");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("////////////////////////");
            Console.WriteLine("returns first element without removing : "+queue.Peek());
            Console.WriteLine("check element is present : " + queue.Contains("name"));
            
        }

    }
}
