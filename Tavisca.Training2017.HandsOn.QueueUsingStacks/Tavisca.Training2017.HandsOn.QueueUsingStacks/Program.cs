using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tavisca.Training2017.HandsOn.QueueAndStack;

namespace Tavisca.Training2017.HandsOn.QueueUsingStacks
{
    class QueueUsingStacks
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of elements in queue would be:");
            int size_of_queue = Convert.ToInt32(Console.ReadLine());
            QueueAndStack.QueueAndStack queueAndStack = new QueueAndStack.QueueAndStack(size_of_queue);
            while (true)
            {
                Console.WriteLine("Enter Your Selection");
                Console.WriteLine("1:Insert");
                Console.WriteLine("2:Delete");
                Console.WriteLine("3:Display");
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            {
                                Console.WriteLine("Enter a number");
                                int item = Convert.ToInt32(Console.ReadLine());
                                if (queueAndStack.EnQueue(item))
                                {
                                    Console.WriteLine("..");    
                                }

                                else
                                    Console.WriteLine("Queue is full");
                                break;
                            }
                        case 2:
                            {
                                queueAndStack.DeQueue();

                                break;
                            }
                        case 3:
                            {
                                queueAndStack.display();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Wrong Choice");
                                break;
                            }
                    }
                }



                catch (Exception e)
                {
                    
                    continue;
                }
            }


        }
    }
}
