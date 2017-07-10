using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training17.HandsOn.SortingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Tavisca.Training2017.HandsOn.Stack.Stack stack;
            int[] array_to_be_sorted ;
            int k;
            Console.WriteLine("Enter the size of the Array To Be Sorted");
            int size = Convert.ToInt32(Console.ReadLine());
            array_to_be_sorted = new int[size];

            stack = new Tavisca.Training2017.HandsOn.Stack.Stack(size);

            Console.WriteLine("Enter {0} elements", size);
            for (int i = 0; i < size; i++)
                array_to_be_sorted[i] = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < size; j++)
            {
                if (array_to_be_sorted[0] > array_to_be_sorted[1])
                {
                    stack.push(array_to_be_sorted[0]);
                    array_to_be_sorted[0] = array_to_be_sorted[1];
                }
                else
                {
                    stack.push(array_to_be_sorted[1]);
                    array_to_be_sorted[1] = array_to_be_sorted[0];
                }
                for (k = 2; k < size - j; k++)
                {
                    if (stack.stack[stack.top_of_stack] > array_to_be_sorted[k])
                    {
                        array_to_be_sorted[k - 1] = array_to_be_sorted[k];
                    }
                    else
                    {
                        array_to_be_sorted[k - 1] = stack.pop();
                        stack.push(array_to_be_sorted[k]);
                    }
                }
                array_to_be_sorted[k - 1] = stack.pop();
            }
            for (int i = 0; i < size; i++)
                Console.Write(array_to_be_sorted[i] + " ");
            Console.ReadKey();
        }
    }
    }

