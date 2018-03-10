using System;
using System.Collections.Generic;
using System.Linq;

namespace EX_LISTS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            List<int> sorted = numbers;

            int sum = 1;
            int sumMax = 0;

           sorted.Sort();

            Console.WriteLine(string.Join(" ",numbers));






            //numbers.RemoveAll(n=>n==0)
        }
    }
    
}
