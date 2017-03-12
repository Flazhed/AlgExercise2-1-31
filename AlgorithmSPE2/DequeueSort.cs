using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSPE2
{
    public class DequeueSort
    {
        public LinkedList<int> deck { get; set; }

        public DequeueSort()
        {
            Random rnd = new Random();
            this.deck = new LinkedList<int>();
            for (int i = 1; i <= 13; i++)
            {
                deck.AddFirst(i);
            }
            this.deck = new LinkedList<int>(deck.OrderBy(i => rnd.Next(int.MaxValue)));
        }


        public void Print()
        {
            foreach (var card in deck)
            {
                Console.Write(card + " - ");
            }
            Console.WriteLine();
        }


        public void Sort2()
        {

            bool swap = true;
            LinkedListNode<int> first;
            LinkedListNode<int> second;
            while (true)
            {
                swap = false;

                for (int i = 0; i < deck.Count; i++)
                {

                    if (deck.First.Value > deck.First.Next.Value)
                    {
                        
                        first = deck.First;
                        second = deck.First.Next;
                        deck.RemoveFirst();
                        deck.RemoveFirst();
                        deck.AddFirst(first);
                        deck.AddFirst(second);
                        first = deck.First;
                        deck.RemoveFirst();
                        deck.AddLast(first);
                        Console.WriteLine("Swapped");
                    }
                    else
                    {
                        first = deck.First;
                        deck.RemoveFirst();
                        deck.AddLast(first);
                        
                        swap = true;
                    }

                    Print();
                }


            }

        }

        public void Sort()
        {
            LinkedListNode<int> first;
            LinkedListNode<int> second;
            int index = 2;
            int counter = 0;
            while (index <= 13)
            {
                counter++;
                if (deck.First.Value == index)
                {
                    first = deck.First;
                    second = deck.First.Next;
                    deck.RemoveFirst();
                    deck.RemoveFirst();
                    deck.AddFirst(first);
                    deck.AddFirst(second);
                }
                if (deck.First.Value == index - 1 && deck.First.Next.Value == index)
                {
                    index++;
                }

                first = deck.First;
                deck.RemoveFirst();
                deck.AddLast(first);

                Print();
            }
            Console.WriteLine("Times in the loop: " + counter);
        }



    }
}
