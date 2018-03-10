using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();


            while (true)
            {
                List<string> command = Console.ReadLine().Split(' ').ToList();

                if (command.Count == 2)
                {
                    int numToDelete = int.Parse(command[1]);

                    numbers.RemoveAll(n => n == numToDelete);
                }
                else if (command.Count == 3)
                {
                    int numToInsers = int.Parse(command[1]);
                    int positionToInsers = int.Parse(command[2]);

                    numbers.Insert(positionToInsers, numToInsers);
                }
                else if (command.Count == 1)
                {
                    if (command[0] == "Odd")
                    {
                        foreach (var num in numbers)
                        {
                            if (num % 2 == 1)
                            {
                                Console.Write($"{num} ");
                            }
                            else
                            {
                                continue;
                            }
                        }

                        break;
                    }
                    else if (command[0] == "Even")
                    {
                        foreach (var num in numbers)
                        {
                            if (num % 2 == 0)
                            {
                                Console.Write($"{num} ");
                            }
                            else
                            {
                                continue;
                            }
                        }

                        break;

                    }
                }
            }
        }
    }
}
