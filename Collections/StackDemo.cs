using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public  class StackDemo
    {
        public static void Demo()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);  
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            foreach(int i in stack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("////////////////////");

            Console.WriteLine("get the top element and remove from the stack : "+stack.Pop());
            Console.WriteLine("get the top element without remove"+stack.Peek());
            //stack.Clear();
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("count of stack elements : " + stack.Count);
            Console.WriteLine("check element is present : "+ stack.Contains(1));

        }
    }
}
