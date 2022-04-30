﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class LinkedList
    {
        public Node head;
        public void Add(int data)
        { 
        Node node=new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else 
            {
                Node temp = head;
                while (temp.next != null)
                { 
                temp= temp.next;    
                }
                temp.next = node;
                Console.WriteLine("inserted into Linked List "+node.data);
            }
        }
        public void Display()
        { 
        Node temp=head;
            if (temp == null)
            { 
            Console.WriteLine("Linked List is Emplty");
            }
            while (temp != null)
            { 
            Console .Write(temp.data+" ");
                temp=temp.next;
            }
        }
    }
}