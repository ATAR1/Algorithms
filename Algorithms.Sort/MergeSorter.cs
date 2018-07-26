using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Sort
{
    public class MergeSorter : Sorter
    {
        public override int[] Sort(int[] mass)
        {
            return MergeSort(mass, 0, mass.Length-1).ToArray();
            
        }

        private Queue<int> MergeSort(int[] mass, int p, int r)
        {
            if(p!=r)
            {
                int q = (p + r) / 2;
                var stack1 = MergeSort(mass, p, q);
                var stack2 = MergeSort(mass, q + 1, r);
                return Merge(stack1, stack2);
            }
            else
            {
                var stack = new Queue<int>();
                stack.Enqueue(mass[p]);
                return stack;
            }
        }

        private Queue<int> Merge(Queue<int> stack1, Queue<int> stack2)
        {
            Queue<int> result = new Queue<int>();
            var mass1 = stack1.ToArray();
            var mass2 = stack2.ToArray();
            while (stack1.Count > 0 || stack2.Count > 0)
            {
                if (stack1.Count == 0)
                { 
                    result.Enqueue(stack2.Dequeue());
                    continue;
                }
                if (stack2.Count == 0)
                {
                    result.Enqueue(stack1.Dequeue());
                    continue;                    
                }
                if (stack1.Peek() < stack2.Peek())
                {
                    result.Enqueue(stack1.Dequeue());
                }
                else
                {
                    result.Enqueue(stack2.Dequeue());
                }
            }
            Console.WriteLine($"{String.Join(",",mass1)} U {String.Join(",", mass2)} = {String.Join(",", result.ToArray())}  ");
            return result;
        }
    }
}
