using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MergeSortClass;
namespace Tavisca.Training2017.HandsOn.MergingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            MergeSortClass mergeSortClass = new MergeSortClass();
            Console.WriteLine("Enter Number of Arrays ");
            int number_of_arrays = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Number of Elements in Every array");
            int number_of_elements = Convert.ToInt32(Console.ReadLine());

            int size = 0;


            int[][] array = new int[number_of_arrays][];

            int[] masterArray = new int[number_of_arrays * number_of_elements];


            for (int i = 0; i < number_of_arrays; i++)
            {
                Console.WriteLine("Enter the " + (i + 1) + "th array");
                array[i] = new int[number_of_elements];
                for (int j = 0; j < number_of_elements; j++)
                {
                    array[i][j] = Convert.ToInt32(Console.ReadLine());
                    masterArray[size] = array[i][j];
                    size++;
                }
            }
            for (int z = 0; z < (number_of_arrays * number_of_elements); z++)
            {
                Console.WriteLine(masterArray[z]);

            }
            int[] result = mergeSortClass.MergeSortArray(masterArray, 0, masterArray.Length - 1);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.ReadKey();
        
        }
    }
}
