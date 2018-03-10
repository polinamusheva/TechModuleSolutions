using System;
using System.Linq;


namespace _10._Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
            int differenece = int.Parse(Console.ReadLine());

            int sumOfPairs = 0;

            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (Math.Abs(arr[j]-arr[i])==differenece)
                    { 
                        sumOfPairs++;
                    }
                }
            }

            Console.WriteLine(sumOfPairs);
        }
    }
}
