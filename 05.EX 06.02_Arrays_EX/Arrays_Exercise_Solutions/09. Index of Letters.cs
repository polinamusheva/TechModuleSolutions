using System;


namespace _09._Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = new char[26];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (char)(97 + i);
              
            }
                        
            char[] arrToCompare = Console.ReadLine().ToLower().ToCharArray();

            foreach (var letter in arrToCompare)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (letter == arr[i])
                    {
                        Console.WriteLine($"{letter} -> {i}");
                    }
                }
                                
            }
        }
    }
}
