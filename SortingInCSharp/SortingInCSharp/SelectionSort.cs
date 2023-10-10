using System;
namespace SortingInCSharp
{
    public static class SelectionSort
    {

        public static int[] SortAscending(int[] array)
        {
            int minIndex;
            int len = array.Length;

            for(int i = 0; i< len; i++)
            {
                minIndex = i;
                for(int j = i+1; j< len; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                Swap(ref array, i, minIndex);
            }

            return array;
        }

        public static int[] SortDescending(int[] array)
        {
            int maxIndex = -1;
            int len = array.Length;

            for (int i = 0; i < len; i++)
            {
                maxIndex = i;
                for (int j = i + 1; j < len; j++)
                {
                    if (array[j] > array[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                Swap(ref array, i, maxIndex);
            }

            return array;
        }

        public static void Swap(ref int[] array, int index1, int index2)
    {
        int temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;

    }
}
}

