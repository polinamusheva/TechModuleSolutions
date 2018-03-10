using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split(' ').ToArray();
            string[] secondLine = Console.ReadLine().Split(' ').ToArray();

            

            int lineMin = Math.Min(firstLine.Length, secondLine.Length);

            int sum1 = 0;
            int sum2 = 0;


            for (int i = 0; i < lineMin; i++)
            {
                

                if (firstLine[i] == secondLine[i])
                {
                    sum1++;
                }

            }

            string[] firstLineRotated = firstLine.Reverse().ToArray();
            string [] secondLineRotated= secondLine.Reverse().ToArray();

            int lineMinReversed = Math.Min(firstLineRotated.Length, secondLineRotated.Length);

            for (int i = 0; i < lineMinReversed; i++)
            {


                if (firstLineRotated[i] == secondLineRotated[i])
                {
                    sum2++;
                }

            }




            Console.WriteLine(Math.Max(sum1, sum2));
        }
    }
}
