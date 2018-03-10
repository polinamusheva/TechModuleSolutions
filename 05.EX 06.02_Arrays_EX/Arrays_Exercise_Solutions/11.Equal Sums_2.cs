using System;
using System.Linq;

namespace _11.Equal_Sums_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            //Console.WriteLine(string.Join("", arr));

            int sumLeft = 0;
            int sumRight = 0;
            int indexFound = -1;


            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    sumLeft += arr[j];
                }

                for (int k = arr.Length - 1; k > i; k--)
                {
                    sumRight += arr[k];
                }

                if (sumRight==sumLeft)
                {
                    indexFound = i;
                }

                sumLeft = 0;
                sumRight = 0;
            }
            
            if (indexFound==-1)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine(indexFound);
            }
            
        }
    }
}
