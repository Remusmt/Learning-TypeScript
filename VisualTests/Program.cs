using DataStructures.Arrays;
using DataStructures.Trees;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace VisualTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] x = { 2, -1, -4, -3, 3 };
            //int[] y = { 2, -2, 4, 1, -3 };

            //int[] x = { 1, -1, -2 };
            //int[] y = { 1, -1, -2 };

            //int[] x = { 1, -2, -2 };
            //int[] y = { 1, -2, 2 };
            //Console.WriteLine(GetDistance(0, 0, -2, -1).ToString());
            Console.WriteLine(new DateTime());
            TestTree();
        }

        public static int Solution(string S, int K)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            string newStr = GetNewString(S, K);
            char current = newStr[0];
            StringBuilder returnStr = new StringBuilder();
            int currentCount = 0;
            for (int i = 0; i < newStr.Length; i++)
            {
                if (newStr[i] == current)
                {
                    currentCount++;
                    if (i == newStr.Length - 1)
                    {
                        returnStr.Append($"{currentCount.ToString()}{current}");
                    }
                }
                else
                {
                    if (currentCount > 1)
                    {
                        returnStr.Append($"{currentCount.ToString()}{current}");
                    }
                    else
                    {
                        returnStr.Append(current);
                    }

                    currentCount = 1;
                }
                current = newStr[i];
            }
            return returnStr.Length;
        }

        private static string GetNewString(string S, int K)
        {
            char previous = S[0];
            char startChar = char.MinValue;
            for (int i = 0; i < S.Length; i++)
            {
                if (previous > S[i])
                {
                    startChar = previous;
                }
                previous = S[i];
            }
            return S.Remove(S.IndexOf(startChar), K);
        }

        //private static double GetDistanceFromCenter(int x1, int y1, int x2, int y2)
        //{
        //    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        //}

        //private static int GetRadius(string S, int[] x, int[] y)
        //{
        //    //Get repeated tag
        //    List<char> str = new List<char>();
        //    int index = 0;
        //    char repeatedChr = char.MinValue;
        //    for (int i = 0; i < S.Length; i++)
        //    {
        //        if (str.Contains(S[i]))
        //        {
        //            index = i;
        //            repeatedChr = S[i];
        //            break;
        //        }
        //        else
        //        {
        //            str.Add(S[i]);
        //        }
        //    }
        //    int firstIndex = S.IndexOf(repeatedChr);
        //    double distanceA = GetDistanceFromCenter(0, 0, x[firstIndex], y[firstIndex]);
        //    double distanceB = GetDistanceFromCenter(0, 0, x[index], y[index]);
        //    double inside = distanceA > distanceB ? distanceA : distanceB;
        //    int pointsInside = 0;
        //    for (int i = 0; i < S.Length; i++)
        //    {
        //        double distanceFromCenter = GetDistanceFromCenter(0, 0, x[i], y[i]);
        //        if (distanceFromCenter < inside)
        //        {
        //            pointsInside++;
        //        }
        //    }
        //    return pointsInside;
        //}

        private static void TestTree()
        {
            BinaryTree binaryTree = new BinaryTree(25);
            binaryTree.Insert(20);
            binaryTree.Insert(23);
            binaryTree.Insert(2);
            binaryTree.Insert(10);
            binaryTree.Insert(3);
            binaryTree.Insert(50);
            binaryTree.Insert(18);
            binaryTree.PrintInOrder();
        }

        //private static void TestSorting()
        //{
        //    int[] data = new int[99999];
        //    int randomSeed = 20;
        //    Stopwatch watch = new Stopwatch();
        //    double elapsedTime;  // time in second, accurate to about millseconds


        //    IntArrayGenerate(data, randomSeed);

        //    watch.Reset();
        //    watch.Start();
        //    Sorting.IntArrayInsertionSort(data);
        //    watch.Stop();
        //    elapsedTime = watch.ElapsedMilliseconds / 1000.0;
        //    Console.WriteLine("Insertion Sort: {0:F3}", elapsedTime);

        //    watch.Reset();
        //    watch.Start();
        //    Sorting.IntArrayQuickSort(data);
        //    watch.Stop();
        //    elapsedTime = watch.ElapsedMilliseconds / 1000.0;
        //    Console.WriteLine("Quick Sort: {0:F3}", elapsedTime);

        //    watch.Reset();
        //    watch.Start();
        //    Sorting.FrameworkSort(data);
        //    watch.Stop();
        //    elapsedTime = watch.ElapsedMilliseconds / 1000.0;
        //    Console.WriteLine("System Sort: {0:F3}", elapsedTime);

        //    watch.Reset();
        //    watch.Start();
        //    Sorting.IntArrayBubbleSort(data);
        //    watch.Stop();
        //    elapsedTime = watch.ElapsedMilliseconds / 1000.0;
        //    Console.WriteLine("Bubble Sort: {0:F3}", elapsedTime);


        //    watch.Reset();
        //    watch.Start();
        //    Sorting.IntArraySelectionSort(data);
        //    watch.Stop();
        //    elapsedTime = watch.ElapsedMilliseconds / 1000.0;
        //    Console.WriteLine("Selection Sort: {0:F3}", elapsedTime);
        //}
        //public static void IntArrayGenerate(int[] data, int randomSeed)
        //{
        //    Random r = new Random(randomSeed);
        //    for (int i = 0; i < data.Length; i++)
        //        data[i] = r.Next();
        //}
    }
}
