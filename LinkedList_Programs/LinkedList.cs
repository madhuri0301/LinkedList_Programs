using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList_Programs
{
    class LinkedList
    {
        Node head;
        public void Add(int data)
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
    }
}
