using System;
using System.Linq;

namespace _08._Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();

            int sum = 1;
            int sumMax = 1;
            int indexMax = input[0];

            for (int i = 0; i < input.Length-1; i++)

            {
                for (int k = i+1; k < input.Length; k++)
                {
                    if (input[i]==input[k])
                    {
                        sum++;
                    }

                }

                if (sum>sumMax)
                {
                    sumMax = sum;
                    indexMax = input[i];
                   
                }

                sum = 1;
            }
                       
            Console.WriteLine(indexMax);
        }
    }
}
