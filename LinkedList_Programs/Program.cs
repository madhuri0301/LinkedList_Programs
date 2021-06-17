﻿using System;

namespace LinkedList_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Append(26);
            linkedList.Append(45);
            linkedList.InsertAtGivenPosition(2, 30); //inserting element on 2nd Position 
            linkedList.Display();
            Console.WriteLine("Removed first element ", +linkedList.RemoveFirstElement().data);
            Console.WriteLine("Linked List Created");
            linkedList.Display();

           
        }
    }
}
