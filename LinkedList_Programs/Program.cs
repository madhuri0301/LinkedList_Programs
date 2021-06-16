using System;

namespace LinkedList_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Append(26);
            linkedList.Append(45);
            linkedList.Append(50);
            Console.WriteLine("Linked List Created");
            linkedList.Display();

           
        }
    }
}
