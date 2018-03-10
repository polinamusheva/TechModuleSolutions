using System;
using System.Linq;

namespace _06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //Console.WriteLine(arr[0]);

            int sum = 1;
            int sumMax = 0;
            int numFound = arr[0];
           // int numLatest = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i]==arr[i-1])
                {
                    sum++;

                    if (sum>sumMax)
                    {
                        numFound = arr[i];
                    }
                                        
                }

                else 

                {
                    if (sumMax<sum)
                    {
                        sumMax = sum;
                       // numFound= arr[i-1];

                    }
                    
                    sum = 1;

                }
            }

            
            int[] finalArr = new int[Math.Max(sumMax,sum)];

            for (int i = 0; i < finalArr.Length; i++)
            {
                finalArr[i] = numFound;
            }

            //Console.WriteLine(sumMax);

            Console.WriteLine(string.Join(" ",finalArr));


        }
    }
}
