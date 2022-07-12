using System.Text;

namespace GenerateNumberFromRandomOperations
{
    public class Program
    {
        const int MAX_TIMES = 5000;
        const int MIN_VALUE = 0;
        const int MAX_VALUE = 100;
        static void Main()
        {
            ConsoleUI consoleUI = new();
            int num = consoleUI.RequestInteger();
            int amount = consoleUI.RequestAmountOfNumbers();

            for (int i = 0; i < MAX_TIMES; i++)
            {
                string formula = GenerateNumericalExpression(num, amount);
                int numExpression = (int)Evaluate(formula);
                if (numExpression == num)
                {
                    Console.WriteLine($"{numExpression} = {formula}");
                    break;
                }
                if (i == MAX_TIMES - 1)
                {
                    Console.WriteLine($"No numerical expression equaling {num} could be built.");
                }
            }
        }
        static int[] GenerateSetOfRandomNumbers(int amount)
        {
            int[] setOfRandomNums = new int[amount];
            Random random = new Random();
            for (int i = 0; i < amount; i++)
            {
                setOfRandomNums[i] = random.Next(MIN_VALUE, MAX_VALUE);
            }
            return setOfRandomNums;
        }

        static string GenerateNumericalExpression(int num, int amount)
        {
            string[] operators = { "+", "-", "*" };
            int[] randomNums = GenerateSetOfRandomNumbers(amount);
            StringBuilder sb = new();
            Random random = new Random();

            for (int i = 0; i < amount; i++)
            {
                sb.Append(randomNums[i]);
                if (i < amount - 1)
                {
                    sb.Append(operators[random.Next(0, 3)]);
                }
            }
            return sb.ToString();
        }

        static double Evaluate(String expression)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                return Convert.ToDouble(dt.Compute(expression, String.Empty));
            }
            catch (OverflowException ex)
            {
                return default;
            }
            catch (InvalidCastException ex2)
            {
                return default;
            }
            return default;
        }
    }
}