using System;

using System.Collections.Generic;
using System.Linq;

namespace _3._Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int[] conditions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int numsToTake = conditions[0];
            int numsToDelete = conditions[1];
            int numToCompare = conditions[2];

            List<int> numbersSelected = new List<int>(numsToTake);

          
            for (int i = 0; i < numsToTake; i++)
            {
                numbersSelected.Add(numbers[i]);
            }

            for (int i = 0; i < numsToDelete; i++)
            {
                numbersSelected.RemoveAt(0);
            }

            for (int i = 0; i < numbersSelected.Count; i++)
            {
                if (numbersSelected[i]==numToCompare)
                {
                    Console.WriteLine("YES!");
                    return;
                }
               
            }

            Console.WriteLine("NO!");

                                    
        }
    }
}
