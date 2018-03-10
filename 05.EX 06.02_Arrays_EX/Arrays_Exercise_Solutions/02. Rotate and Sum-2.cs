using System;
using System.Linq;


namespace _02._Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] newarr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                       
            int[] temp = new int[newarr.Length];

            int[] sum = new int[newarr.Length];

            int rotations = int.Parse(Console.ReadLine());

                      

            for (int i = 0; i < rotations; i++)
            {
                for (int j = 0; j < temp.Length; j++)
                {
                    
                    if (j - i % newarr.Length <= 0)
                    {
                        temp[j] = newarr[newarr.Length - 1 + j - i % newarr.Length];

                    }
                    else
                    {
                        temp[j] = newarr[j - i % newarr.Length - 1];
                    }

                    
                    sum[j] += temp[j];

                }
            }

            Console.WriteLine(string.Join(" ", sum));

        }
    }
}
