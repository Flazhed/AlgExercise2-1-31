using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSPE2
{
    class Program
    {
        static void Main(string[] args)
        {

            DequeueSort dsort = new DequeueSort();
            dsort.Print();
            dsort.Sort();
            dsort.Print();


            ISorter selectionSorter = new SelectionSorter("SelectionSort");
            ISorter inseritionSorter = new InsertionSorter("InsertionSort");
            ISorter mergeSort = new MergeSorter("MergeSort");

            Experiment(1000, selectionSorter, 4);
            Console.WriteLine("-------------");
            Experiment(1000, inseritionSorter, 4);
            Console.WriteLine("-------------");
            Experiment(100000, mergeSort, 2);




            Console.ReadLine();
        }

        public static void Experiment(int startValue, ISorter sorter, int factor)
        {
            
            ArrayGenerator arrGenerator = new ArrayGenerator(10000);
            int expected = 0;
            int[] arr;
            for (int i = 0; i < 5; i++)
            {

                Stopwatch sw = new Stopwatch();
                arr = arrGenerator.GetUnsortedArray(startValue);
                sw.Start();
                sorter.Sort(arr);
                sw.Stop();
                Console.WriteLine("{0} for n = {1}. Elapsed = {2} ms. Expected = {3} ms", sorter.GetSortingMethodName(), startValue, sw.Elapsed.Milliseconds, expected);
                startValue = startValue*2;
                expected = sw.Elapsed.Milliseconds*factor;
            }

        }


        public static void PrintArray(int[] arr)
        {

            foreach (int hest in arr)
            {
                Console.Write(hest + " - ");
            }
            Console.WriteLine();
        }
    }
}