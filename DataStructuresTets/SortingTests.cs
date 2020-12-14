using DataStructures.Arrays;
using NUnit.Framework;
using System;

namespace DataStructuresTets
{
    public class SortingTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void BubbleSort()
        {
            int[] arr = { 9, 67, 3, 7, 4, 1, 3, 5, 77, 9, 44, 63, 23, 67, 91, 21, 34, 29, 71, 19, 29, 92, 39, 93, 49, 94, 59, 95, 69, 96, 97, 79, 98, 89, 81, 1882, 18, 82, 28 };
            Sorting.IntArrayBubbleSort(arr);

            Assert.AreEqual(arr[0], 1);
        }

        [Test]
        public void FrameWorkSort()
        {
            int[] arr = {64630, 11735, 14216, 99233, 14470, 4978, 73429, 38120, 51135 };
            Sorting.FrameworkSort(arr);
            Assert.AreEqual(arr.Length/2, 4);
        }

        [Test]
        public void SelectionSort()
        {
            int[] arr = { 9, 67, 3, 7, 4, 1, 3, 5, 77, 9, 44, 63, 23, 67, 91, 21, 34, 29, 71, 19, 29, 92, 39, 93, 49, 94, 59, 95, 69, 96, 97, 79, 98, 89, 81, 1882, 18, 82, 28 };
            Sorting.IntArraySelectionSort(arr);

            Assert.AreEqual(arr[0], 1);
        }

        [Test]
        public void InsertionSort()
        {
            int[] arr = { 9, 67, 3, 7, 4, 1, 3, 5, 77, 9, 44, 63, 23, 67, 91, 21, 34, 29, 71, 19, 29, 92, 39, 93, 49, 94, 59, 95, 69, 96, 97, 79, 98, 89, 81, 1882, 18, 82, 28 };
            Sorting.IntArrayInsertionSort(arr);

            Assert.AreEqual(arr[arr.Length - 1], 1882);
        }

        [Test]
        public void QuickSort()
        {
            int[] arr = { 9, 67, 3, 7, 4, 1, 3, 5, 77, 9, 44, 63, 23, 67, 91, 21, 34, 29, 71, 19, 29, 92, 39, 93, 49, 94, 59, 95, 69, 96, 97, 79, 98, 89, 81, 1882, 18, 82, 28 };
            Sorting.IntArrayQuickSort(arr);

            Assert.AreEqual(arr[arr.Length - 1], 1882);
        }
    }
}