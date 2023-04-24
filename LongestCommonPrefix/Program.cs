namespace LongestCommonPrefix;
public class Solution
{
    public static void Main(string[] args)
    {
        string[] strs = new string[] { "ab", "a"};
        Console.WriteLine(LongestCommonPrefix(strs));
    }

    public static string LongestCommonPrefix(string[] strs)
    {
        string prefix = "";
        string baseStr = strs.OrderByDescending(s => s.Length).First();
        bool tester = false;
        foreach (string str in strs)
        {
            if (str.Length == 0)
            {
                return prefix;
            }
        }
        for (int counter = 0; counter < baseStr.Length; counter++)
        {
            foreach (string str in strs)
            {
                if (counter == str.Length || str[counter] != baseStr[counter])
                {
                    tester = true;
                    break;
                }
            }
            if (tester)
            {
                break;
            }
            else
            {
                prefix += baseStr[counter];
            }
        }
        return prefix;
    }
}