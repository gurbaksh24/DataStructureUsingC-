using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    
    class Stack:ICommonMethods
    {
        const int MAX = 100;
        int []data=new int[MAX];
        int top;
        public Stack()
        {
            top = -1;
        }
        public void Add(int value)
        {
            if(top>=MAX)
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                data[++top] = value;
            }
        }

        public void Display()
        {
            if (top <= -1)
            {
                Console.WriteLine("Stack Underflow");
            }
            else
            {
                for (int index = top; index >= 0; index--)
                {
                    Console.WriteLine(data[index]);
                }
            }
        }

        public int Remove()
        {
            int responseData=-1;
            if(top<=-1)
            {
                Console.WriteLine("Stack Underflow");
            }
            else
            {
                responseData = data[top--];
            }
            return responseData; 
        }

        public void Sort()
        {
            int temp;
            for(int index1=0;index1<=top;index1++)
            {
                for(int index2=0;index2<=top-index1-1;index2++)
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
        public int GetTop()
        {
            int resonseData = -1;
            if(top<=-1)
            {
                Console.WriteLine("Stack Underflow");
            }
            else
            {
                resonseData = data[top];
            }
            return resonseData;
        }
    }

}
