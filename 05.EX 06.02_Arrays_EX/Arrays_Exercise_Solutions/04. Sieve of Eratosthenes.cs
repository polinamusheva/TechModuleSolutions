using System;
using System.Linq;


namespace _04._Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            bool[] arr = new bool[num + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = true;
            }

            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i]==true)
                {
                    for (int j = i+1; j < arr.Length; j++)
                    {
                        if (j%i==0)
                        {
                            arr[j] = false;
                        }
                    }
                }
            }
            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] == true)
                {
                    
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
      
            //foreach (bool i in arr)-?????? ZASHTO NE BACHKA???
            //{
            //    arr[i] = true;
            //}
        }
    }
}
