using System;

namespace GenerateNumberFromRandomOperations // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main()
        {
            int[] setOfRandomNums = GenerateSetOfRandomNumbers(10);
            string[] setOfRandomOperators = GenerateSetOfRandomOperators(5);
            //Console.WriteLine(setOfRandomNums[4]);
            //foreach (int i in setOfRandomNums)
            //    Console.WriteLine(i);
            foreach (string s in setOfRandomOperators)
                Console.WriteLine(s);
        }

        /// Generate a specific number from a set of random numbers and a set of random operators ///
        /// Example 1 | Input: 3 + 2 * 2 - 6 | Output: 1
        /// Example 2 | Input: 7 - 9 * 6 - 3 | Output: -50
        /// Example 3 | Input: 9 - 0 + 0 * 5 | Output: 9
        /// 

        static int[] GenerateSetOfRandomNumbers(int amount)
        {
            int[] setOfRandomNums = new int[amount];
            Random random = new Random();
            for (int i = 0; i < amount; i++)
            {
                setOfRandomNums[i] = random.Next(0, 10);
            }
            return setOfRandomNums;
        }

        static string[] GenerateSetOfRandomOperators(int amount)
        {
            string[] setOfRandomOperators = new string[amount];
            Random random = new Random();
            for (int i = 0; i < amount; i++)
            {
                int rand = random.Next(0, 4);
                if (rand == 0)
                {
                    setOfRandomOperators[i] = "+";
                }
                else if (rand == 1)
                {
                    setOfRandomOperators[i] = "-";
                }
                else if (rand == 2)
                {
                    setOfRandomOperators[i] = "*";
                }
                else
                {
                    setOfRandomOperators[i] = "/";
                }
            }
            return setOfRandomOperators;
        }
    }
}