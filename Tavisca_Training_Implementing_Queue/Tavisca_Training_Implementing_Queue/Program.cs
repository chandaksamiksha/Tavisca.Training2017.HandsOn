using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tavisca_Training_Implementing_Queue
{
    class Queue
    {
        static void Main(string[] args)
        {
            Queue p = new Queue();
            int[] queue = new int[10];
            int choice;
            int front = -1;
            int rear = -1;
            int number;
            do
            {
                choice = p.menu();
                switch (choice)
                {
                    case 1:

                        if (rear == 10 - 1)
                        {
                            Console.WriteLine("Queue Overflow");
                        }
                        else
                        {
                            if (front == -1)
                            {
                                front = 0;
                            }
                                Console.WriteLine("Enter the Number to be entered onto the Queue");
                                number = Convert.ToInt32(Console.ReadLine());
                                rear = rear + 1;
                                queue[rear] = number;
                              
                            }
                                               
                        break;

                    case 2:
                        if (front == -1 || front > rear)
                        {
                            Console.WriteLine("Queue Underflow");
                        }
                     
                        else
                        {
                            Console.WriteLine("The Number Deleted from the Queue ");
                            front = front + 1;
                            
                        }
                        break;

                    case 3:

                        Console.WriteLine("Queue Contains :");
                        if (front == -1)
                        {
                            Console.WriteLine("Queue Is Empty");
                        }
                        for (int i = front; i <= rear; i++)
                        {
                            Console.WriteLine(queue[i]);
                        }
                        break;


                    default:
                        {
                            Console.WriteLine("....");
                            break;
                        }
                }
            } while (choice <= 3);
            Console.ReadLine();

        }

        public int menu()
        {
            int selection;
            Console.WriteLine("Enter your Selection");
            Console.WriteLine("1.Enter Element into Queue");
            Console.WriteLine("2.Delete Element From Queue");
            Console.WriteLine("3.Display The Queue");
            Console.WriteLine("4.Exit");
            selection = Convert.ToInt32(Console.ReadLine());
            return selection;
        

    }
    }
}
