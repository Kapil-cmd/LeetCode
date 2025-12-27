
using System.Diagnostics.CodeAnalysis;

namespace LeetCode
{
    public class BigO
    {
        public static int GetFirstElements(int[] arr)
        {
            return arr[0];
        }
        public static int BinarySearch(int[] arr, int start, int end, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] == target) return mid;
                else if (arr[mid] < target) left = mid + 1;
                else right = mid - 1;
            }
            return -1;
            //logn
        }
        public static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target) return i;
            }
            return -1;
            //O(n)
        }
        //public static int MergeSort(int[] arr, int left, int mid, int right)
        //{
        //} 
        public static void PrintPair(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.WriteLine(arr[1] + "," + arr[j]);
                }
            }
        }
        //O(n2)
    }
}
