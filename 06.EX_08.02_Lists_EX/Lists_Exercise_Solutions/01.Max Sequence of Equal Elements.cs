using System;
using System.Collections.Generic;
using System.Linq;

namespace EX_08._02_Lists_NEW
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int count = 1;
            int countMax = 1;
            int valueIndexMax = numbers[0];


            for (int i = 0; i < numbers.Count - 1; i++)
            {


                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                }
                else
                {
                    if (count > countMax)
                    {
                        countMax = count;
                        valueIndexMax = numbers[i];
                    }

                    count = 1;
                }


            }

            if (count <= countMax)
            {
                //string result = new string((char)(numbers[numbers.Count - 1]), count);

                // List<int> result = new List<int>();

                for (int i = 0; i < countMax; i++)
                {
                    Console.Write($"{valueIndexMax} ");
                }
                Console.WriteLine();
            }


            else
            {

                for (int i = 0; i < count; i++)
                {
                    Console.Write($"{numbers[numbers.Count - 1]} ");
                }
                Console.WriteLine();
            }

        }
    }
}