using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Arrays
{
    public static class Sorting
    {
        public static void IntArrayBubbleSort(int[] data)
        {
            if (ArrayIsSorted(data)) return;

            int i, j, c = 0;
            int N = data.Length;

            for (j = N - 1; j > 0; j--)
            {
                c += 1;
                for (i = 0; i < j; i++)
                {
                    if (data[i] > data[i + 1])
                        Exchange(data, i, i + 1);
                }
            }
        }

        public static void IntArraySelectionSort(int[] data)
        {
            if (ArrayIsSorted(data)) return;
            int i;
            int N = data.Length;

            for (i = 0; i < N - 1; i++)
            {
                int k = IntArrayMin(data, i);
                if (i != k)
                    Exchange(data, i, k);
            }
        }

        public static void IntArrayInsertionSort(int[] data)
        {
            int i, j;
            int N = data.Length;

            for (j = 1; j < N; j++)
            {
                for (i = j; i > 0 && data[i] < data[i - 1]; i--)
                {
                    Exchange(data, i, i - 1);
                }
            }
        }

        public static bool ArrayIsSorted(int[] data)
        {
            // Insertion sorting looks like a great way to check if array is sorted
            int i, j;
            int N = data.Length;

            for (j = 1; j < N; j++)
            {
                for (i = j; i > 0 && data[i] < data[i - 1];)
                {
                    return false;
                }
            }
            return true;
        }

        private static void IntArrayQuickSort(int[] data, int l, int r)
        {
            int i, j;
            int x;

            i = l;
            j = r;

            x = data[(l + r) / 2]; /* find pivot item */
            while (true)
            {
                while (data[i] < x)
                    i++;
                while (x < data[j])
                    j--;
                if (i <= j)
                {
                    Exchange(data, i, j);
                    i++;
                    j--;
                }
                if (i > j)
                    break;
            }
            if (l < j)
                IntArrayQuickSort(data, l, j);
            if (i < r)
                IntArrayQuickSort(data, i, r);
        }

        public static void IntArrayQuickSort(int[] data)
        {
            IntArrayQuickSort(data, 0, data.Length - 1);
        }

        public static void FrameworkSort(int[] data)
        {
            Array.Sort(data);
        }

        private static void Exchange(int[] data,int indexA, int indexB)
        {
            int temp = data[indexA];
            data[indexA] = data[indexB];
            data[indexB] = temp;
        }

        private static int IntArrayMin(int[] data, int start)
        {
            int minPos = start;
            for (int pos = start + 1; pos < data.Length; pos++)
                if (data[pos] < data[minPos])
                    minPos = pos;
            return minPos;
        }
    }
}
