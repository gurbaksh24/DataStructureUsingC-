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
        int[] _data;
        int _front;
        int _rear;
        public Queue()
        {
            _front = -1;
            _rear = -1;
            _data = new int[MAX];
        }
        public void Add(int value)
        {
            if(_rear==-1)
            {
                _front = 0;
                _rear = 0;
                _data[_rear] = value;
            }
            else if(_rear+1>=MAX)
            {
                Console.WriteLine("Queue Overflow");
            }
            else if(_rear+1<MAX)
            {
                _data[++_rear] = value;
            }
        }

        public int Remove()
        {
            int responseData = -1;
            if(_rear==-1)
            {
                Console.WriteLine("Queue Underflow");
            }
            else
            {
                responseData = _data[_front];
                if(_front==_rear)
                {
                    _front = -1;
                    _rear = -1;
                }
                else
                {
                    _front++;
                }
            }
            return responseData;
        }

        public void Display()
        {
            if (_front == -1)
            {
                Console.WriteLine("Queue Underflow");
            }
            else
            {
                for (int index = _front; index <= _rear; index++)
                {
                    Console.Write(_data[index]+"\t");
                }
                Console.WriteLine();
            }
        }

        public void Sort()
        {
            int temp;
            for(int index1=_front;index1<=_rear;index1++)
            {
                for(int index2=_front;index2<=_rear-index1-1;index2++)
                {
                    if(_data[index2]>_data[index2+1])
                    {
                        temp = _data[index2];
                        _data[index2] = _data[index2 + 1];
                        _data[index2 + 1] = temp;
                    }
                }
            }
        }
        public int Peek()
        {
            int responseData = -1;
            if (_front == -1)
            {
                Console.WriteLine("Queue Underflow");
            }
            else
                responseData = _data[_front];
            return responseData;
        }
        public bool IsEmpty()
        {
            if (_front == -1)
                return true;
            else
                return false;
        }
        public bool IsFull()
        {
            if (_front==0&&_rear + 1 >= MAX)
                return true;
            else
                return false;
        }
    }
}
