using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Sort
{
    public class BubleSorter : Sorter
    {
        public override int[] Sort(int[] mass)
        {
            bool swapped;
            var length = mass.Length;
            do
            {
                swapped = false;
                for (int j = 1; j < length; j++)
                {
                    if (mass[j - 1] > mass[j])
                    {
                        Utils.Swap(mass, j - 1, j);
                        swapped = true;
                    }
                }
                Console.WriteLine(String.Join(",", mass));
            } while (swapped);
            return mass;
        }
    }
}
