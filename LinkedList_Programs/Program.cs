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
            linkedList.Append(30);
            linkedList.InsertAtGivenPosition(3, 40); //inserting element on 2nd Position //UC4 and UC8
            linkedList.Display();
            Console.WriteLine(linkedList.Search(15));
            Console.WriteLine("Linked List Created");
            Console.WriteLine("Remove last element ", +linkedList.RemoveLastElement().data); // Removing Last Element
            linkedList.Display();

            linkedList.DeleteNode(40); //Deleting The E#lement
            Console.WriteLine("After Deletion ");
            linkedList.Display();
            Console.WriteLine("Linkelist Size " + linkedList.Count()); //Finding Size Of Node
        }
    }
}
