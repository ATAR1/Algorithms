using Algorithms.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cui
{
    class Program
    {
        static void Main(string[] args)
        {
            var mass = new[] { 10, 4, 5, 8, 3, 1, 7, 6, 9, 1, 2 };
            Console.WriteLine("Сортировка пузырьком");
            Console.WriteLine(String.Join(",", mass));
            Console.WriteLine();
            Sorter sorter = new BubleSorter();
            var sorted = sorter.Sort(mass.ToArray());
            Console.WriteLine();
            Console.WriteLine(String.Join(",", sorted));
            Console.WriteLine("Сортировка вставкой");
            Console.WriteLine(String.Join(",", mass));            
            Console.WriteLine();
            sorter = new InsertionSorter();
            Console.WriteLine();
            sorted = sorter.Sort(mass.ToArray());
            Console.WriteLine();
            Console.WriteLine(String.Join(",", sorted));
            Console.WriteLine("Сортировка выбором");
            Console.WriteLine(String.Join(",", mass));
            Console.WriteLine();
            sorter = new SelectionSorter();
            Console.WriteLine();
            sorted = sorter.Sort(mass.ToArray());
            Console.WriteLine();
            Console.WriteLine(String.Join(",", sorted));
            Console.WriteLine("Сортировка слиянием");
            Console.WriteLine(String.Join(",", mass));
            Console.WriteLine();
            sorter = new MergeSorter();
            Console.WriteLine();
            sorted = sorter.Sort(mass.ToArray());
            Console.WriteLine();
            Console.WriteLine(String.Join(",", sorted));

            Console.ReadLine();
        }
    }
}
