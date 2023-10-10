using System;
namespace SortingInCSharp
{
	public static class MergeSort
	{
		public static int[] SortAscending(int[] array)
		{
			int len = array.Length;
			Divide(array, 0, len-1);
			return array;
		}

		public static void Divide(int[] array, int left, int right)
		{
			if(left >= right)
			{
				return;
			}

			int mid = left + (right - left) / 2;

            Divide(array, left, mid);
			Divide(array, mid + 1, right);
			Conquer(array, left, mid, right);

		}

		public static void Conquer(int[] array, int left, int mid, int right)
		{
			int lengthArrayLeft = mid - left + 1;
			int lengthArrayRight = right - mid;
			int[] leftArray = new int[lengthArrayLeft];
			int[] rightArray = new int[lengthArrayRight];
			int i, j;

			for(i = 0;i < lengthArrayLeft; i++)
			{
				leftArray[i] = array[left + i];
			}

			for(i = 0; i< lengthArrayRight; i++)
			{
				rightArray[i] = array[mid + 1 + i];
			}

			i = 0;
			j = 0;
			int k = left;
			while(i < lengthArrayLeft && j < lengthArrayRight)
			{
				if (leftArray[i] < rightArray[j])
				{
					array[k++] = leftArray[i++];
				}
				else
				{
					array[k++] = rightArray[j++];
				}
			}

			while (i < lengthArrayLeft)
			{
				array[k++] = leftArray[i++];
			}

            while (j < lengthArrayRight)
            {
                array[k++] = rightArray[j++];
            }
        }
	}
}

