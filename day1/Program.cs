using System;
using System.IO;
using System.Linq;

namespace day1
{
    class Program
    {
        static void Main(String[] args)
        {
            try
            {

            var ints = File.ReadAllLines("input.txt")
                .Select(s => Int32.Parse(s)).ToList();

                var howManyIntsToSum = 3;
                var requiredSum = 2020;

            var solution = Solve(ints, howManyIntsToSum, requiredSum);
            Console.WriteLine(solution);
            Console.WriteLine("linq solution " + LinqSolution(ints));
            } catch(Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }
        
        // Solution using linq(lang integrated query)
        static int LinqSolution(IEnumerable<int> ints)
        {
            return
            (from x in ints
             from y in ints.Skip(1)
             from z in ints.Skip(2)
             where x + y + z == 2020
             select x * y * z).FirstOrDefault();    
        }
        
        // recursive solution for fun
        static int Solve(IEnumerable<int> ints, int howManyIntsToSum, int requiredSum)
        {
            if (howManyIntsToSum == 0 || ! ints.Any()) return 0;
            var head = ints.First();
            var tail = ints.Skip(1);
            if (howManyIntsToSum == 1 && head == requiredSum) return(head);
            var result = head * Solve(tail, howManyIntsToSum - 1, requiredSum - head);
            if (result != 0) return result;
            return Solve(tail, howManyIntsToSum, requiredSum);
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