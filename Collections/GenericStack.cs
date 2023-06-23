using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public  class GenericStack
    {
        public static void Demo()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
        }
    }
}
