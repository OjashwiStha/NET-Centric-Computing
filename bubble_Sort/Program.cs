using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bubble_Sort
{
    public class BubbleSorter
    {
        public void Sort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BubbleSorter sorter = new BubbleSorter();

            int[] array = { 4, 20, 2, 11, 52, 40, 8 };

            Console.WriteLine("Unsorted Array:");
            sorter.PrintArray(array);

            sorter.Sort(array);

            Console.WriteLine("Sorted Array:");
            sorter.PrintArray(array);
        }
    }
}

