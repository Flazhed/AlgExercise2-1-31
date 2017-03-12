using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSPE2
{
    public class InsertionSorter : ISorter
    {
        private string sorterMethodName;

        public InsertionSorter(string name)
        {
            this.sorterMethodName = name;
        }

        public void Sort(int[] array)
        {
            int element, j;
            for (int i = 1; i < array.Length; i++)
            {
                element = array[i];
                j = i - 1;
                while (j >= 0 && array[j] > element)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = element;
            }
        }

        public string GetSortingMethodName()
        {
            return this.sorterMethodName;
        }
    }
}
