using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            

            int[] firstFourth = new int[arr.Length/4];

            for (int i = 0; i < firstFourth.Length; i++)
            {
                firstFourth[i] = arr[i];

               
            }

            int[] middleFourths = new int[arr.Length / 2];

            for (int i = 0; i < middleFourths.Length; i++)
            {
                middleFourths[i] = arr[firstFourth.Length+i];
               

            }

            int[] lastFourths = new int[arr.Length / 4];

            for (int i = 0; i < lastFourths.Length; i++)
            {
                lastFourths[i] = arr[firstFourth.Length+middleFourths.Length + i];
            }

            int[] lastFourthsReversed = lastFourths.Reverse().ToArray();

            int[] final = new int[arr.Length/2];

            for (int i = 0; i < final.Length/2; i++)
            {
                final[i] = middleFourths[i] + firstFourth[firstFourth.Length-1 - i];
            }

            //for (int i = final.Length / 2; i < final.Length; i++)
            //{
            //    final[i] = middleFourths[i] + lastFourthsReversed];
            //}

            for (int i = 0; i < final.Length; i++)
            {
                final[final.Length - 1 - i] = middleFourths[middleFourths.Length - 1 - i] + lastFourthsReversed[lastFourthsReversed.Length - 1 - i];
            }

           Console.WriteLine(string.Join(" ", final));
        }
    }
}
