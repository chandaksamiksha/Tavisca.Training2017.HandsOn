using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taviisca.Training2017.HandsOn.QueueDataStructure;

namespace Tavisca.Training17.HandsOn.StackUsingQueue
{
    class StackUsingQueues
    {
        static void Main(string[] args)
        {
            int number;
            QueueDs queueDs1 = new QueueDs();
            QueueDs queueDs2 = new QueueDs();
            while (true)
            {
                Console.WriteLine("Enter Your Selection");
                Console.WriteLine("1:Push");
                Console.WriteLine("2:Pop");
                Console.WriteLine("3:Display");
                
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            {
                                Console.WriteLine("Enter a number");
                                int item = Convert.ToInt32(Console.ReadLine());
                                if (queueDs1.EnQueue(item))
                                {
                                    Console.WriteLine("..");
                                }

                                else
                                    Console.WriteLine("Queue is full");
                                break;
                            }
                        case 2:
                            {
                                while (queueDs1.front<queueDs1.rear)
                                {
                                    number = queueDs1.DeQueue();
                                    queueDs2.EnQueue(number);
                                }
                          
                                int element = queueDs1.DeQueue();
                                Console.WriteLine("Poped Element :{0}", element);

                                while (!queueDs2.isQueueEmpty())
                                    queueDs1.EnQueue(queueDs2.DeQueue());

                                break;
                            }
                        case 3:
                            {
                                queueDs1.Display();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Wrong Choice");
                                break;
                            }
                    }
                }
        }

    }
}