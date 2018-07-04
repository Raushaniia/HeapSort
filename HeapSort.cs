using System;

namespace HeapSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = {1, 4, 2, 7, 8, 3, 9, 5, 10, 100, 14, 12, 32, 34};
            HeapSort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadLine();
        }

        public static void HeapSort(int[] array)
        {
            int heapSize = array.Length;
            int indexOfLastParent = (heapSize - 2) / 2;
            for (int i = indexOfLastParent; i >= 0; i--)
                CreateHeap(array, heapSize, i);

            for (int i = array.Length - 1; i > 0; i--)
            {
                Swap(array, i, 0);

                heapSize--;
                CreateHeap(array, heapSize, 0);
            }
        }

        public static void CreateHeap(int[] array, int heapSize, int index)
        {
            int left = 2 * index + 1;
            int right = 2 * index + 2;
          
            int max = index;

            if (left < heapSize && array[left] > array[index])
                max = left;

            if (right < heapSize && array[right] > array[max])
                max = right;

            if (max != index)
            {
                Swap(array, max, index);

                CreateHeap(array, heapSize, max);
            }
        }

        public static void Swap(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}
