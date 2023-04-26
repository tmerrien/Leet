// Input
string haystack = "leetcode", needle = "leeto";

// Output
int index = StrStr(haystack, needle);
Console.WriteLine(index);

// Algorithm
int StrStr(string haystack, string needle)
{
    if (needle.Length == 0)
    {
        return 0;
    }
    if (haystack.Length == 0)
    {
        return -1;
    }
    for (int i = 0; i < haystack.Length; i++)
    {
        if (haystack[i] == needle[0])
        {
            if (haystack.Length - i < needle.Length)
            {
                return -1;
            }
            bool found = true;
            for (int j = 0; j < needle.Length; j++)
            {
                if (haystack[i + j] != needle[j])
                {
                    found = false;
                    break;
                }
            }
            if (found)
            {
                return i;
            }
        }
    }
    return -1;
}