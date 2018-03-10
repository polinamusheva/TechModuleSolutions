using System;
using System.Collections.Generic;
using System.Linq;


namespace _6._Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();


            int sum = 0;


            for (int i = 0; i < list.Count; i++)
            {
                List<int> subList = list[i].Reverse().Select(n => int.Parse(n.ToString())).ToList();

                                
                int sumString = int.Parse(string.Join("", subList));
               
                sum += sumString;
                
            }

            Console.WriteLine(sum);

        }
    }
}
