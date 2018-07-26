using System;
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
            Stack stack = new Stack();

            Console.WriteLine("------------------------Data Structures--------------------------");
            Console.WriteLine("1. Stack");
            Console.WriteLine("2. Queue");
            Console.WriteLine("3. Linked List");
            int.TryParse(Console.ReadLine(), out choice);
            switch (choice)
            {
                case 1:

                    Console.WriteLine("1. Add");
                    Console.WriteLine("2. Remove");
                    Console.WriteLine("3. Display");
                    Console.WriteLine("4. Sort");
                    Console.WriteLine("5. Get Top Value");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter Element to be Inserted");
                            stack.Add(int.Parse(Console.ReadLine()));
                    } 
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
    }
}
