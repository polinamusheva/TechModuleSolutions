using System;
using System.Linq;

namespace _05._Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstCharArr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondCharArr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            //Console.WriteLine(string.Join("",firstCharArr));
            //Console.WriteLine(string.Join("", secondCharArr));

            for (int i = 0; i < Math.Min(firstCharArr.Length,secondCharArr.Length); i++)
            {
                if (firstCharArr[i]==secondCharArr[i])
                {
                    continue;
                }
                else if (firstCharArr[i] > secondCharArr[i])
                {
                    Console.WriteLine(string.Join("",secondCharArr));
                    Console.WriteLine(string.Join("", firstCharArr));
                    return;

                }
                else
                {
                    Console.WriteLine(string.Join("", firstCharArr));
                    Console.WriteLine(string.Join("", secondCharArr));
                    return;
                }


            }

            if (firstCharArr.Length<=secondCharArr.Length)
            {
                Console.WriteLine(string.Join("", firstCharArr));
                Console.WriteLine(string.Join("", secondCharArr));
            }
            else
            {
                Console.WriteLine(string.Join("", secondCharArr));
                Console.WriteLine(string.Join("", firstCharArr));
            }

        }
    }
}
