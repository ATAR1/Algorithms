using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Sort
{
    public class InsertionSorter : Sorter
    {
        public override int[] Sort(int[] mass)
        {
            int sortedLength = 1;
            while (mass.Length > sortedLength)
            {
                int current = mass[sortedLength];
                var pos = FindPosition(mass, sortedLength, current);
                Shift(mass, sortedLength, pos);
                mass[pos] = current;
                Console.WriteLine(String.Join(",", mass));
                sortedLength++;
            }
            return mass;
        }
        
        public static void Shift(int[] mass, int sortedLength, int pos)
        {
            for (int i = sortedLength; i > pos; i--)
            {
                mass[i] = mass[i - 1];
            }
        }

        public static int FindPosition(int[] mass, int sortedLength, int current)
        {
            int i = 0;
            while((i < sortedLength)&&(mass[i]<current))
            {
                i++;
            }
            return i;
        }
    }
}
