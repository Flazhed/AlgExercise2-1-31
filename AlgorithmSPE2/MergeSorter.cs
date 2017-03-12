using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSPE2
{
    public class MergeSorter : ISorter
    {

        private string name;
        private int[] overhead;

        public MergeSorter(string name)
        {
            this.name = name;
        }

        public void Sort(int[] array)
        {
            overhead = new int[array.Length];
            this.MergeSort(0, array.Length-1, array);
        }

        public string GetSortingMethodName()
        {
            return this.name;
        }

        private void MergeSort(int low, int high, int[] arr)
        {
            if (low < high)
            {
                int mid = low + (high - low)/2;
                MergeSort(low, mid, arr);
                MergeSort(mid + 1, high, arr);
                Merge(low, mid, high, arr);
            }
            
        }

        private void Merge(int low, int mid, int high, int[] arr)
        {
            for (int index = low; index <= high; index++)
            {
                overhead[index] = arr[index];
            }

            int i = low;
            int j = mid + 1;

            for (int k = low; k <= high; k++)
            {
                if (i > mid) arr[k] = overhead[j++];
                else if(j > high) arr[k] = overhead[i++];
                else if(overhead[j] < overhead[i]) arr[k] = overhead[j++];
                else arr[k] = overhead[i++];
            }

        }

    }
}
