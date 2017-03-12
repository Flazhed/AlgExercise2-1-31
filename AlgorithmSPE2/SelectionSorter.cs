using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSPE2
{
    public class SelectionSorter : ISorter
    {
        private string SortingMethodName;

        public SelectionSorter(string name)
        {
            this.SortingMethodName = name;
        }

        public void Sort(int[] array)
        {
            int index, newSmall;
            for (int i = 0; i < array.Length - 1; i++)
            {
                index = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[index])
                    {
                        index = j;
                    }
                }
                newSmall = array[index];
                array[index] = array[i];
                array[i] = newSmall;
            }
        }

        public string GetSortingMethodName()
        {
            return this.SortingMethodName;
        }
    }
}
