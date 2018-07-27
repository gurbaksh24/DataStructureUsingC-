using System;

namespace DataStructures
{
    class Node
    {
        int _data;
        Node _link;

        public Node(int data)
        {
            this.Data = data;
        }

        public int Data { get => _data; set => _data = value; }
        internal Node Link { get => _link; set => _link = value; }
    }
    class LinkedList : ICommonMethods
    {
        static Node head = null;
        
        public void Add(int data)
        {
            Node newNode = new Node(data);
            newNode.Link = head;
            head = newNode;
        }

        public int Remove()
        {
            int data = head.Data;
            head = head.Link;
            return data;
        }
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List Underflow");
            }
            Node disp = head;
            while (disp != null)
            {
                Console.WriteLine(disp.Data + "\t");
                disp = disp.Link;
            }
        }
        public void Sort()
        {
            int size=Size();
            for(int index1=0;index1<size;index1++)
            {
                int temp;
                Node temporaryNode = head;
                Node next = head.Link;
                for(int index2=0;index2<size-1;index2++)
                {
                    if(temporaryNode.Data>next.Data)
                    {
                        temp = temporaryNode.Data;
                        temporaryNode.Data = next.Data;
                        next.Data = temp;
                    }
                    temporaryNode = next;
                    next = next.Link;
                    
                }
            }
        }

        
        public void AddDataAtPosition(int data, int index)
        {
            if (head == null)
            {
                Add(data);
                return;
            }
            Node temporaryNode = head;
            while (index>1)
            {
                temporaryNode = temporaryNode.Link;
                index--;
            }
            Node addNode = temporaryNode.Link;
            temporaryNode.Link = new Node(data);
            temporaryNode.Link.Link = addNode;
        }
        public int RemoveAtIndex(int index)
        {
            Node removeNode = head;
            int responseData=-1;
            if(index<1)
            {
                Console.WriteLine("Please choose another index");
                return -1;
            }
            if(index==1)
            {
                responseData = head.Data;
                head = head.Link;
                return responseData;
            }
            while(index>0)
            {
                if (removeNode == null)
                    return -1;

                removeNode = removeNode.Link;
                index--;
            }
            responseData = removeNode.Data;
            removeNode.Data = removeNode.Link.Data;
            removeNode.Link = removeNode.Link.Link;
            return responseData;
        }
        public static int Size()
        {
            int count=0;
            Node temporaryNode = head;
            while(temporaryNode!=null)
            {
                count++;
                temporaryNode=temporaryNode.Link;
            }
            return count;
        }
    }
}