namespace SortingInCSharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] array = new int[] { -2, 45, -12, 11, -9 };

        //int[] sortedArray = BubbleSort.SortDescending(array);
        //int[] sortedArray = SelectionSort.SortDescending(array);
        int[] sortedArray = InsertionSort.SortAscending(array);
        //int[] sortedArray = MergeSort.SortAscending(array);
        //int[] sortedArray = QuickSort.SortDescending(array);



        Display(sortedArray);

        Console.ReadLine();

    }

    public static void Display(int[] array)
    {
        for(int i = 0;i< array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}

