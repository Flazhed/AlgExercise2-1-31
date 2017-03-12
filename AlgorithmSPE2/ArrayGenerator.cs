using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSPE2
{
    public class ArrayGenerator
    {
        private int maxValue;
        private Random random;

        public ArrayGenerator(int maxValue)
        {
            this.maxValue = maxValue;
            this.random = new Random();
        }

        public int[] GetUnsortedArray(int size)
        {
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(maxValue);
            }
            return arr;
        }

    }
}
