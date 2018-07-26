using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Queue:ICommonMethods
    {
        const int MAX = 100;
        int[] data;
        int front;
        int rear;
        public Queue()
        {
            front = -1;
            rear = -1;
            data = new int[MAX];
        }
        public void Add(int value)
        {
            if(rear==-1)
            {
                front = 0;
                rear = 0;
                data[rear] = value;
            }
            else if(rear+1>=MAX)
            {
                Console.WriteLine("Queue Overflow");
            }
            else if(rear+1<MAX)
            {
                data[++rear] = value;
            }
        }

        public int Remove()
        {
            int responseData = -1;
            if(rear==-1)
            {
                Console.WriteLine("Queue Underflow");
            }
            else
            {
                responseData = data[front];
                if(front==rear)
                {
                    front = -1;
                    rear = -1;
                }
                else
                {
                    front++;
                }
            }
            return responseData;
        }

        public void Display()
        {
            if (front == -1)
            {
                Console.WriteLine("Queue Underflow");
            }
            else
            {
                for (int index = front; index <= rear; index++)
                {
                    Console.Write(data[index]+"\t");
                }
                Console.WriteLine();
            }
        }

        public void Sort()
        {
            int temp;
            for(int index1=front;index1<=rear;index1++)
            {
                for(int index2=front;index2<=rear-index1-1;index2++)
                {
                    if(data[index2]>data[index2+1])
                    {
                        temp = data[index2];
                        data[index2] = data[index2 + 1];
                        data[index2 + 1] = temp;
                    }
                }
            }
        }
        public int Peek()
        {
            int responseData = -1;
            if (front == -1)
            {
                Console.WriteLine("Queue Underflow");
            }
            else
                responseData = data[front];
            return responseData;
        }
        public bool IsEmpty()
        {
            if (front == -1)
                return true;
            else
                return false;
        }
        public bool IsFull()
        {
            if (front==0&&rear + 1 >= MAX)
                return true;
            else
                return false;
        }
    }
}
