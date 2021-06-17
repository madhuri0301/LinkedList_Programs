using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList_Programs
{
    class LinkedList
    {
        Node head;
        public void Add(int data) // method to add new linked list
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                node.next = head;
                head = node;
            }
        }
        public void Append(int data) // method to append the value to linked list
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node n = head;
                while (n.next != null)
                {
                    n = n.next;
                }
                n.next = node;
            }
        }
        public void InsertAtGivenPosition(int position, int data) // method to insert an element on a given position
        {
            Node node = new Node(data);
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node n = head, previous = head, after;
                for (int pos = 1; pos < position; pos++)
                {
                    n = n.next;
                    if (pos == position - 2)
                    {
                        previous = n;
                    }
                }
                after = n;
                previous.next = node;
                node.next = after;
            }
        }
        public Node RemoveFirstElement()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is empty.");
            }
            else
            {
                head = head.next;
            }
            return this.head;

        }
        public void Display() // method to display the value
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            else
            {
                Node n = head;
                while (n.next != null)
                {
                    Console.Write(n.data + " ");
                    n = n.next;
                }
                Console.Write(n.data + "\n");
            }
        }
    }
}
