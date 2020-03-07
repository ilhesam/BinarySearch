using System;
using System.Linq;

namespace BinarySearch
{
    class Program
    {
        // Binary Search with Random Numbers

        static void Main(string[] args)
        {
            int[] array = new int[10];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100, 999);
            }

            Console.Write("Please Enter Key Number for Binary Search : ");
            int keyNumber = int.Parse(Console.ReadLine() ?? random.Next(100, 999).ToString());

            Console.WriteLine("---------------------------------------------------");

            var searchResult = BinarySearch(array, keyNumber);
            Console.WriteLine(searchResult ? "Exist" : "Not Exist");
        }

        private static bool BinarySearch(int[] array, int key)
        {
            var sortedArray = array
                .OrderBy(n => n)
                .ToArray();

            int min = 0;
            int max = sortedArray.Length - 1;
            int mid = 0;

            while (min <= max)
            {
                mid = (min + max) / 2;

                if (sortedArray[mid] == key)
                {
                    return true;
                }
                else if (sortedArray[mid] < key)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }

            return false;
        }
    }
}