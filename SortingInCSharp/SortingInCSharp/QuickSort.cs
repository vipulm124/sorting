using System;
namespace SortingInCSharp
{
	public static class QuickSort
	{

		public static int[] SortAscending(int[] array)
		{
            QuickSortLogicAscending(array, 0, array.Length - 1);
			return array;
		}

        public static int[] SortDescending(int[] array)
        {
            QuickSortLogicDescending(array, 0, array.Length - 1);
            return array;
        }

        public static int PartitionAscending(int[] array, int start, int end)
		{
			int partitionIndex = start;
			int pivotValue = array[end];

			for(int i = start; i < end; i++)
			{
				if (array[i] < pivotValue)
				{
					Swap(ref array, i, partitionIndex);
					

					partitionIndex++;
				}
			}
			Swap(ref array, partitionIndex, end);

			return partitionIndex;
		}

        public static int PartitionDescending(int[] array, int start, int end)
        {
            int partitionIndex = start;
            int pivotValue = array[end];

            for (int i = start; i < end; i++)
            {
                if (array[i] > pivotValue)
                {
                    Swap(ref array, i, partitionIndex);


                    partitionIndex++;
                }
            }
            Swap(ref array, partitionIndex, end);

            return partitionIndex;
        }

        public static void QuickSortLogicAscending(int[] array, int start, int end)
		{
			if (start < end)
			{
				int partitionIndex = PartitionAscending(array, start, end);
                QuickSortLogicAscending(array, start, partitionIndex - 1);
                QuickSortLogicAscending(array, partitionIndex + 1, end);
			}
		}


        public static void QuickSortLogicDescending(int[] array, int start, int end)
        {
            if (start < end)
            {
                int partitionIndex = PartitionDescending(array, start, end);
                QuickSortLogicDescending(array, start, partitionIndex - 1);
                QuickSortLogicDescending(array, partitionIndex + 1, end);
            }
        }

        public static void Swap(ref int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;

        }
    }
}

