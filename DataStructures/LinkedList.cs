using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Node
    {
        int data;
        Node next;
        
        public Node()
        {
            next = null;
            data = 0;
        }
        public Node(int data,Node link)
        {
            this.data = data;
            next = link;
        }
        public int Data
        {
            get { return data; }
            set { data = value; }
        }

        internal Node Next
        {
            get { return next; }
            set { next = value; }
        }

    }
    class LinkedList:ICommonMethods
    {
        Node start;
        Node end;
        int size;

        public LinkedList()
        {
            start = null;
            end = null;
            size = 0;
        }
        public void Add(int data)
        {
            Node newNode = new Node(data,null);
            size++;
            if(start==null)
            {
                start = newNode;
                end = start;
            }
            else
            {
                newNode.Next = start;
                start = newNode;
            }
        }

        public void AddAtEnd(int data)
        {
            Node newNode = new Node(data, null);
            size++;
            if(start==null)
            {
                start = newNode;
                end = start;
            }
            else
            {
                end.Next = newNode;
                end = newNode;
            }
        }
        public int Remove()
        {
            if (size == 0)
            {
                Console.WriteLine("Linked List is empty");
                return 0;
            }
            else
            {
                start = start.Next;
                return 1;
            }

        }
        public int RemoveAtEnd()
        {
            if (size == 0)
            {
                Console.WriteLine("Linked List is empty");
                return 0;
            }
            else
            {
                end = start.Next;
                return 1;
            }s

        }
        public void Display()
        {
            if(size==0)
            {
                Console.WriteLine("Linked List Underflow");
                return;
            }
            if(start.Next==null)
            {
                Console.WriteLine(start.Data);
                return;
            }
            Node ref=start;
        }

        public void Sort()
        {
            throw new NotImplementedException();
        }
    }
}
