using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static QuickSortLogic.ProgramQS;
using static MergeSortLogic.ProgramMS;

namespace SortsTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void QuickSort_For_Integer_Numbers()
        {
            int[] inputArray = new int[] { 5, 7, 8, 6, 3, 1, 9, 2, 10, 4, 11, 18, 13, 19, 20, 17, 15, 12, 14, 16 };
            int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            QuickSort(inputArray);
            CollectionAssert.AreEqual(expected, inputArray);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void QuickSort_For_Null_unsortedArray_Throw_ArgumentNullException()
        {
            int[] unsortedArray = null;
            QuickSort(unsortedArray);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void QuickSort_For_Empty_unsortedArray_Throw_ArgumentException()
        {
            int[] unsortedArray = { };
            QuickSort(unsortedArray);
        }
    }

    [TestClass]
    public class UnitTestsMS
    {
        [TestMethod]
        public void MergeSort_For_Integer_Numbers()
        {
            int[] inputArray = new int[] { 5, 7, 8, 6, 3, 35, 1, 9, 2, -10 };
            int[] expected = new int[] { -10, 1, 2, 3, 5, 6, 7, 8, 9, 35 };
            MergeSort(inputArray);
            CollectionAssert.AreEqual(expected, inputArray);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void QuickSort_for_null_unsortedArray_Throw_ArgumentNullException()
        {
            int[] unsortedArray = null;
            MergeSort(unsortedArray);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void QuickSort_for_empty_unsortedArray_Throw_ArgumentException()
        {
            int[] unsortedArray = { };
            MergeSort(unsortedArray);
        }

    }
}
