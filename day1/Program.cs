using System;
using System.IO;
using System.Linq;

namespace day1
{
    class Program
    {
        static void Main(String[] args)
        {
            var ints = File.ReadAllLines("input.txt")
                .Select(s => Int32.Parse(s)).ToList();
            Console.WriteLine(SolvePart2(ints));
        }
        
        static int SolvePart2(List<int> ints)
        {
            for (int i = 0; i < ints.Count; i++)
            {
               for (int j = i+1; j < ints.Count; j++)
               {
                for (int k = 0; k < ints.Count; k++)
                {
                    if (ints[i] + ints[j] + ints[k] == 2020)
                    {
                        Console.WriteLine("Found it!");
                        return (ints[i] * ints[j] * ints[k]);
                    }
                }
              } 
            }
            return 0;
        }
        
        static int SolvePart1(List<int> ints)
        {
            for (int i = 0; i < ints.Count; i++)
            {
               for (int j = i+1; j < ints.Count; j++)
               {
                if (ints[i] + ints[j] == 2020)
                {
                    Console.WriteLine("Found it!");
                    return (ints[i] * ints[j]);
                }
               } 
            }
            return 0;
        }

    }
}