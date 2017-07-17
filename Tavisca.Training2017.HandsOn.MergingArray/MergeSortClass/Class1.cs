using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortClass
{
    public class MergeSort
    {
        public void Merge(int[] array, int lower_bound, int middle, int upper_bound)
        {
            int i, j, k;
            int size_of_array1 = middle - lower_bound;
            int size_of_array2 = upper_bound - middle;


            int[] firstArray = new int[size_of_array1];
            int[] secondArray = new int[size_of_array2];


            for (i = 0; i < size_of_array1 - 1; i++)
                firstArray[i] = array[lower_bound + i];
            for (j = 0; j < size_of_array2; j++)
                secondArray[j] = array[middle + 1 + j];


            i = 0;
            j = 0;
            k = lower_bound;
            while (i < size_of_array1 && j < size_of_array2)
            {
                if (firstArray[i] <= secondArray[j])
                {
                    array[k] = firstArray[i];
                    i++;
                }
                else
                {
                    array[k] = secondArray[j];
                    j++;
                }
                k++;
            }
            while (i < size_of_array1)
            {
                array[k] = firstArray[i];
                i++;
                k++;
            }
            while (j < size_of_array2)
            {
                array[k] = secondArray[j];
                j++;
                k++;
            }
        }

        public int[] MergeSortArray(int[] array, int lower_bound, int upper_bound)
        {

            if (upper_bound > lower_bound)
            {

                int middle = (lower_bound + upper_bound) / 2;
                MergeSortArray(array, lower_bound, middle);
                MergeSortArray(array, (middle + 1), upper_bound);
                Merge(array, lower_bound, (middle + 1), upper_bound);
            }
            return array;
        }

    }
}

    
