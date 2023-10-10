using System;
namespace SortingInCSharp
{
	public static class InsertionSort
	{
		public static int[] SortAscending(int[] array)
		{
			int len = array.Length;
			for(int i = 1;i < len; i++)
			{
				int temp = array[i];
				int index = i;

				while(index > 0 && array[index-1] > temp)
				{
					array[index] = array[index - 1];
					index = index - 1;
				}
				array[index] = temp;
			}

			return array;
		}

        public static int[] SortDescending(int[] array)
        {
            int len = array.Length;
            for (int i = 1; i < len; i++)
            {
                int temp = array[i];
                int index = i;

                while (index > 0 && array[index - 1] < temp)
                {
                    array[index] = array[index - 1];
                    index = index - 1;
                }
                array[index] = temp;
            }

            return array;
        }
    }
}

