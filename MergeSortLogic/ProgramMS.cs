using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortLogic
{
    public class ProgramMS
    {  
        public static void MergeSort(int[] unsortedArray, int start, int end)
        { 
            if (start<end) 
            { 
                 int middle = (start / 2) + (end / 2); 
                 MergeSort(unsortedArray, start, middle); 
                 MergeSort(unsortedArray, middle + 1, end); 
                 Merge(unsortedArray, start, middle, end); 
            } 
        } 
  
        public static void MergeSort(int[] unsortedArray)
        {
            ArrayChecker(unsortedArray);
            MergeSort(unsortedArray, 0, unsortedArray.Length - 1); 
        }  
 
        private static void Merge(int[] unsortedArray, int start, int middle, int end)
        { 
  
             int left = start; 
             int right = middle + 1; 
             int[] tmp = new int[(end - start) + 1]; 
             int tmpIndex = 0; 
 
             while ((left <= middle) && (right <= end)) 
             { 
                 if (unsortedArray[left] < unsortedArray[right]) 
                 { 
                     tmp[tmpIndex] = unsortedArray[left]; 
                     left = left + 1; 
                 } 
                 else 
                 { 
                     tmp[tmpIndex] = unsortedArray[right]; 
                     right = right + 1; 
                 } 
                 tmpIndex = tmpIndex + 1; 
             } 
  
             if (left <= middle) 
             { 
                 while (left <= middle) 
                 { 
                     tmp[tmpIndex] = unsortedArray[left]; 
                     left = left + 1; 
                     tmpIndex = tmpIndex + 1; 
                 } 
             } 
            
             if (right <= end) 
             { 
                 while (right <= end) 
                 { 
                     tmp[tmpIndex] = unsortedArray[right]; 
                     right = right + 1; 
                     tmpIndex = tmpIndex + 1; 
                 } 
             }  
 
             for (int i = 0; i<tmp.Length; i++) 
             { 
                 unsortedArray[start + i] = tmp[i]; 
             } 
        } 
        
        private static void ArrayChecker(int[] unsortedArray)
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
    }
}
