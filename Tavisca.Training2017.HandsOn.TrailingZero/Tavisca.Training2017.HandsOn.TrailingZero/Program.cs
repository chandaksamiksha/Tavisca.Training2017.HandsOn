using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.HandsOn.TrailingZero
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Base of Number  :2/10");
            int base_of_number = Convert.ToInt32(Console.ReadLine());

            switch (base_of_number)
            {
                case 2:
                    {
                        p.ConvertBinaryToDecimal();
                        break;
                    }
                case 10:
                    Console.WriteLine("Enter the Number");
                    int number = Convert.ToInt32(Console.ReadLine());
                    p.CalculateTrailingZeros(number);
                    break;

                default:
                    Console.WriteLine("Wrong Choice");
                    break;
            }

        }

        public void ConvertBinaryToDecimal()
        {
            int number, binary_value, decimal_value = 0, base_value = 1, remainder;
            Console.Write("Enter a Binary Number(1s and 0s) : ");
            number = int.Parse(Console.ReadLine());
            binary_value = number;
            while (number > 0)
            {
                remainder = number % 10;
                decimal_value = decimal_value + remainder * base_value;
                number = number / 10;
                base_value = base_value * 2;
            }
            CalculateFactorial(decimal_value);
        }

        public void CalculateFactorial(int decimal_value)
        {
            
        }

        public void CalculateTrailingZeros(long number)
        {
            int count = 5;
            long total = 0;

            while ((number / count) >= 1)
            {
                total = total + number / count;
                count = count * 5;
            }
            Console.WriteLine("Total Number of Trailing Zeroes:");
            Console.Write(total);
            Console.ReadLine();
        }
    }
}
