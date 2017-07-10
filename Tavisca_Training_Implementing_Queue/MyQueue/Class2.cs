using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.HandsOn.Queue
{
    public class Queue
    {
        int[] queue = new int[10];
        int rear=-1;
        int front = -1;
        int count = 0;
        int max;

        public bool isQueuefull()
        {
            if (rear == 10 - 1)
                return true;
            else
                return false;
        }
        public void enqueue(int Number)
        {
            if (isQueuefull())
            {
                return 0;
            }
            else
            {
                ++rear;
                queue[rear] = Number;

                return 1;
            }
        }

        public bool isQueueEmpty()
        {
            if(front==0||front>rear)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int dequeue()
        {
            if (isQueueEmpty())
            {
                return 0;
            }
            else
            {
               int number = queue[front];
                ++front;
               return number;
            }
        }
        public void Display()
        {
            for (int i = front; i <= rear; i++)
            {
                Console.WriteLine(queue[i]);
            }
        }
    }
}
