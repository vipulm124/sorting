using System;
namespace SortingInCSharp
{
    public static class BubbleSort
	{
		public static int[] SortAscending(int[] array)
		{
			int len = array.Length;

			for(int i = 0; i < len - 1; i++)
			{
				for (int j = 0 ; j < len - i - 1 ; j++)
				{
					if (array[j] > array[j + 1])
					{
						Swap(ref array, j, j + 1);
					}
				}
			}

			return array;
		}

        public static int[] SortDescending(int[] array)
        {
            int len = array.Length;

            for (int i = 0; i < len - 1; i++)
            {
                for (int j = 0; j < len - i - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        Swap(ref array, j, j + 1);
                    }
                }
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

