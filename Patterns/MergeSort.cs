using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class MergeSort : ISortable
    {
        public double[] Sort(double[] unsorted)
        {
            Sort(unsorted, 0, unsorted.Length - 1);
            return unsorted;
        }
        public void Sort(double[] unsorted, int leftIndex, int rightIndex)
        {
            if (rightIndex > leftIndex)
            {
                int newRightIndex = (leftIndex + rightIndex) / 2;
                int newLeftIndex = newRightIndex + 1;
                Sort(unsorted, leftIndex, newRightIndex);
                Sort(unsorted, newLeftIndex, rightIndex);
                Merge(unsorted, leftIndex, newRightIndex, rightIndex);
            }
        }
        public void Merge(double[] array, int leftIndex, int medIndex,int rightIndex)
        {
            double[] Left = new double[medIndex - leftIndex + 1+1];
            double[] Right = new double[rightIndex - medIndex+1];
            for (var i = leftIndex; i <= medIndex; i++)
                Left[i-leftIndex] = array[i];
            Left[medIndex - leftIndex + 1] = double.MaxValue;
            Right[rightIndex - medIndex] = double.MaxValue;
            for (int i = medIndex + 1; i <= rightIndex; i++)
                Right[i - medIndex - 1] = array[i];
            int k=0, l=0;
            for(int i=leftIndex; i<=rightIndex;i++)
            { 
                if (Left[k]<Right[l])
                {
                    array[i] = Left[k];
                    k++;
                }
                else
                {
                    array[i] = Right[l];
                    l++;
                }
            }

        }
    }
}
