using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[]specialNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int bomb = specialNumbers[0];
            int power = specialNumbers[1];


            while (numbers.Contains(bomb))
            {

            }

            

        }
    }
}
