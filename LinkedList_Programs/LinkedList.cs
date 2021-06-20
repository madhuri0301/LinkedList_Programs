using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList_Programs
{
    public class LinkedList
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
        internal Node RemoveFirstElement() //method for Removing first Element
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
        internal Node RemoveLastElement() //method for Removing Last Element
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is empty.");
                return null;
            }
            else
            {
                Node NewNode = head;
                while (NewNode.next.next != null)
                {
                    NewNode = NewNode.next;
                }
                Node removedNode = NewNode.next;
                NewNode.next = null;
                return removedNode;
            }
        }
        public bool Search(int data) //method To Search The Element From Linked List 
        {
            if (head == null)
                return false;
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    if (temp.data == data)
                        return true;
                    temp = temp.next;
                }
                return false;
            }
        }
        public void DeleteNode(int data) //Method To Delete The Node
        {
            Node temp = head, prev = null;
            if (temp != null && temp.data == data)
            {
                head = temp.next;
                return;
            }
            while (temp != null && temp.data != data)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
                return;
            prev.next = temp.next;
        }

        public int Count() //Method To Count The Node
        {
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
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
