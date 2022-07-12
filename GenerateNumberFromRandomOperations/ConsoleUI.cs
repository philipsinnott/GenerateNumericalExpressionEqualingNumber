using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateNumberFromRandomOperations
{
    public class ConsoleUI
    {
        public int RequestInteger()
        {
            Console.WriteLine("Which integer do you wish to generate?");
            try
            {
                int integer = int.Parse(Console.ReadLine());
                return integer;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return default;
        }

        public int RequestAmountOfNumbers()
        {
            Console.WriteLine("How many integers do you wish the numerical expression should consist of?");
            try
            {
                int amount = int.Parse(Console.ReadLine());
                return amount;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return default;
        }
    }
}
