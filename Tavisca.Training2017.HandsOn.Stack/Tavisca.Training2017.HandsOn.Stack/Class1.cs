using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.HandsOn.Stack
{
    public class Stack
    {
        public int[] stack;
        public int top_of_stack, size;
        public bool push(int number)
        {
            if (top_of_stack < size - 1)
            {
                stack[++top_of_stack] = number;
                return true;
            }
            return false;
        }

        public int pop()
        {
            if (top_of_stack > -1)
                return (stack[top_of_stack--]);
            else return 0;
        }

        public void display()
        {
            if (top_of_stack > -1)
            {
                for (int i = 0; i <= top_of_stack; i++)
                    Console.WriteLine(stack[i] + " ");
            }
            else Console.WriteLine("Stack is empty");
        }

        public Stack(int n)
        {
            stack = new int[n];
            top_of_stack = -1;
            size = n;
        }

    }
}
