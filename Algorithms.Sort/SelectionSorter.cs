using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Sort
{
    public class SelectionSorter : Sorter
    {
        public override int[] Sort(int[] mass)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                var smallestIndex = FindSmalest(mass, i);
                Change(mass, i, smallestIndex);
                Console.WriteLine(String.Join(",", mass));
            }
            return mass;
        }

        public static void Change(int[] mass, int first, int second)
        {
            int temp = mass[first];
            mass[first] = mass[second];
            mass[second] = temp;
        }

        public static int FindSmalest(int[] mass, int sortedLength)
        {
            int smalesstValue = mass[sortedLength];
            int smallestIndex = sortedLength ;
            for (int i = sortedLength; i < mass.Length; i++)
            {
                if(mass[i]<smalesstValue)
                {
                    smalesstValue = mass[i];
                    smallestIndex = i;
                }
            }
            return smallestIndex;
        }
    }
}
