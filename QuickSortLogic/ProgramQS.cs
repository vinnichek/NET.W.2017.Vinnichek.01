using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortLogic
{
    public class ProgramQS
    {
        public static void ArrayChecker(int[] unsortedArray)
        {
            if (unsortedArray == null)
            {
                throw new ArgumentNullException("Array is null.");
            }
            if (unsortedArray.Length == 0)
            {
                throw new ArgumentException("Array is empty.");
            }
        }

        public static void QuickSort(int[] unsortedArray)
        {
            ArrayChecker(unsortedArray);
            QuickSort(unsortedArray, 0, unsortedArray.Length - 1); 
        }


        public static void QuickSort(int[] unsortedArray, int start, int end)
        {
            if (start >= end)
            { 
                return; 
            }

            int num = unsortedArray[start]; 
            int i = start, j = end;  
 
            while (i<j) 
            { 
                 while (i<j && unsortedArray[j]> num) 
                 { 
                     j--; 
                 }

                 unsortedArray[i] = unsortedArray[j]; 
  
                 while (i<j && unsortedArray[i] < num) 
                 { 
                     i++; 
                 }
                 unsortedArray[j] = unsortedArray[i]; 
            }
            unsortedArray[i] = num; 
            QuickSort(unsortedArray, start, i - 1); 
            QuickSort(unsortedArray, i + 1, end); 
        } 
    }
}

