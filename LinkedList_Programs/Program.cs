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
            linkedList.InsertAtGivenPosition(2, 30);
            Console.WriteLine("Linked List Created");
            linkedList.Display();

           
        }
    }
}
