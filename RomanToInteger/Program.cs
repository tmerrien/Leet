using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        string RomanInput = "";
        while (RomanInput == null || RomanInput.Length == 0)
        {
            Console.WriteLine("Enter a Roman Numeral: ");
            RomanInput = Console.ReadLine();
        }
        int IntegerOutput = RomanToInteger(RomanInput);
        Console.WriteLine(IntegerOutput);
    }

    static int RomanToInteger(string s)
    {
        int IntegerOutput = 0;
        if (s != null)
        {
            int[] RomanValues = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] RomanNumerals = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            for (int i = 0; i < RomanValues.Length; i++)
            {
                while (s.StartsWith(RomanNumerals[i]))
                {
                    IntegerOutput += RomanValues[i];
                    s = s.Substring(RomanNumerals[i].Length);
                }
            }
        }
        return IntegerOutput;
    }
}