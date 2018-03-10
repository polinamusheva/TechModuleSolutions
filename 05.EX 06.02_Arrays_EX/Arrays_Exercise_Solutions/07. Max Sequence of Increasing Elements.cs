using System;
using System.Linq;



namespace _07._Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();

            int sum = 1;
            int sumMaxCurrent = 0;
            int sumMax = 0;

            int IndexMax = 0;
            int IndexMaxCurrent = 0;



            for (int i = 1; i < input.Length; i++)
            {


                if (input[i] > input[i - 1])
                {
                    sum++;

                    IndexMaxCurrent = i;

                }

                else
                {
                    sumMaxCurrent = sum;
                    sum = 1;

                    if (sumMaxCurrent > sumMax)
                    {
                        sumMax = sumMaxCurrent;

                        IndexMax = i - 1;


                    }
                }


            }

            int newArrLength = 0;

            if (sum <= sumMax)
            {
                newArrLength = sumMax;
                IndexMax = IndexMax;
            }
            else if (sum > sumMax)
            {
                newArrLength = sum;
                IndexMax = IndexMaxCurrent;
                //IndexMax = input.Length;
            }

            int[] result = new int[newArrLength];

            for (int k = 0; k < result.Length; k++)
            {
                result[k] = input[IndexMax - newArrLength + 1 + k];
            }


            Console.WriteLine(string.Join(" ", result));
        }
    }
}
