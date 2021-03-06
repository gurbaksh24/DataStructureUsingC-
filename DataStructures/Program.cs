﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            int innerChoice=0;
            Console.WriteLine("------------------------Data Structures--------------------------");
            Console.WriteLine("1. Stack");
            Console.WriteLine("2. Queue");
            Console.WriteLine("3. Linked List");
            int.TryParse(Console.ReadLine(), out choice);
            switch (choice)
            {
                case 1:
                    Stack stack = new Stack();
                    while (true)
                    {
                        Console.WriteLine("1. Add");
                        Console.WriteLine("2. Remove");
                        Console.WriteLine("3. Display");
                        Console.WriteLine("4. Sort");
                        Console.WriteLine("5. Get Top Value");
                        Console.WriteLine("6. Exit from Stack");

                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter Element to be Inserted");
                                stack.Add(int.Parse(Console.ReadLine()));
                                break;
                            case 2:
                                Console.WriteLine("Removed " + stack.Remove() + " from the top of the stack");
                                break;
                            case 3:
                                stack.Display();
                                break;
                            case 4:
                                stack.Sort();
                                Console.WriteLine("Sorted Stack");
                                stack.Display();
                                break;
                            case 5:
                                Console.WriteLine("The Top Value of Stack=" + stack.GetTop());
                                break;
                            case 6:
                                innerChoice = 1;
                                break;
                            default:
                                Console.WriteLine("Wrong Choice");
                                break;
                        }
                        if (innerChoice == 1)
                        {
                            innerChoice = 0;
                            break;
                        }
                    }
                    break;
                case 2:
                    Queue queue=new Queue();
                    while (true)
                    {
                        Console.WriteLine("1. Add");
                        Console.WriteLine("2. Remove");
                        Console.WriteLine("3. Display");
                        Console.WriteLine("4. Sort");
                        Console.WriteLine("5. Peek");
                        Console.WriteLine("6. Check Queue is Full");
                        Console.WriteLine("7. Check Queue is Empty");
                        Console.WriteLine("8. Exit from Queue");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter Element to be Inserted");
                                queue.Add(int.Parse(Console.ReadLine()));
                                Console.WriteLine("Data Inserted");
                                break;
                            case 2:
                                Console.WriteLine("Removed " + queue.Remove() + " from the front of the queue");
                                break;
                            case 3:
                                queue.Display();
                                break;
                            case 4:
                                queue.Sort();
                                Console.WriteLine("Sorted Queue");
                                queue.Display();
                                break;
                            case 5:
                                Console.WriteLine("The Front Value of Queue=" + queue.Peek());
                                break;
                            case 6:
                                if(queue.IsFull())
                                    Console.WriteLine("Queue is full");
                                else
                                    Console.WriteLine("Queue is not full");
                                break;
                            case 7:
                                if(queue.IsEmpty())
                                    Console.WriteLine("Queue is empty");
                                else
                                    Console.WriteLine("Queue is not empty");
                                break;
                            case 8:
                                innerChoice = 1;
                                break;
                            default:
                                Console.WriteLine("Wrong Choice");
                                break;
                        }

                        if (innerChoice == 1)
                        {
                            innerChoice = 0;
                            break;
                        }
                    }
                    break;
                case 3:
                    LinkedList linkedList = new LinkedList();
                    while (true)
                    {
                        Console.WriteLine("1. Add");
                        Console.WriteLine("2. Remove");
                        Console.WriteLine("3. Display");
                        Console.WriteLine("4. Sort");
                        Console.WriteLine("5. Insert at specific location");
                        Console.WriteLine("6. Remove from specific location");
                        Console.WriteLine("7. Exit from Queue");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter Element to be Inserted");
                                linkedList.Add(int.Parse(Console.ReadLine()));
                                Console.WriteLine("Data Inserted");
                                break;
                            case 2:
                                Console.WriteLine("Removed " + linkedList.Remove() + " from the linked list");
                                break;
                            case 3:
                                linkedList.Display();
                                break;
                            case 4:
                                linkedList.Sort();
                                Console.WriteLine("Sorted Linked List");
                                linkedList.Display();
                                break;
                            case 5:
                                Console.WriteLine("Enter Data");
                                int requestData = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Index");
                                int index = int.Parse(Console.ReadLine());
                                linkedList.AddDataAtPosition(requestData,index);
                                Console.WriteLine("Data Inserted");
                                break;
                            case 6:
                                Console.WriteLine("Enter Index");
                                int responseData=linkedList.RemoveAtIndex(int.Parse(Console.ReadLine()));
                                Console.WriteLine("Data Removed");
                                break;
                            case 7:
                                innerChoice = 1;
                                break;
                            default:
                                Console.WriteLine("Wrong Choice");
                                break;
                        }

                        if (innerChoice == 1)
                        {
                            innerChoice = 0;
                            break;
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
