using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca_Training_Implementing_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] stack1 = new int[10];
            int[] stack2 = new int[10];
            int choice;
            int top_of_stack1 = -1;
            int top_of_stack2 = -1;
            int number;
            do
            {
                choice = p.menu();
                switch (choice)
                {
                    case 1:

                        if (top_of_stack1 >= 10 - 1)
                        {
                            Console.WriteLine("Queue Overflow");
                        }
                        else
                        {
                            Console.WriteLine("Enter the Number to be entered");
                            number = Convert.ToInt32(Console.ReadLine());
                            ++top_of_stack1;
                            stack[top_of_stack1] = number;
                        }
                        break;

                    case 2:
                        if (top_of_stack1 <= -1)
                        {
                            Console.WriteLine("Queue Underflow");
                        }
                        else
                        {
                            if (top_of_stack2 <= -1)
                            {
                                do
                                {
                                    ++top_of_stack2;
                                    stack2[top_of_stack2] = stack1[top_of_stack1];
                                    --top_of_stack1;
                                } while (top_of_stack1 != -1);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Deleted Element from Queue ");
                                top_of_stack2--;
                            }
                        }
                    case 3:

                        Console.WriteLine("Stack Contains :");
                        for (int i = top_of_stack2; i >= 0; i--)
                        {
                            Console.WriteLine(stack2[i]);
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
            Console.WriteLine("1.Insert");
            Console.WriteLine("2.Delete");
            Console.WriteLine("3.Display");
            Console.WriteLine("4.Exit");
            selection = Convert.ToInt32(Console.ReadLine());
            return selection;
        }
    }
}
