using System;
using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ArrayListDemo.Demo();
            SortedListDemo.Sorted();
            HashTableDemo.HashDemo();
            StackDemo.Demo();
            QueueDemo.DemoQ();
            GenericList.Demo();
            DictionaryDemo.Demo();
            GenericSortedList.Demo();
            GenericStack.Demo();
            GenericQueue.Demo();
            Operations.Operation();
        }
    }
}
