static bool IsValid(string s)
{
    foreach (char c in s)
    {
        switch(c)
        {
            case '(': case ')': case '[': case ']': case '{': case '}':
                break;
            default:
                return false;
        }
    }
    /*validify the input as a whole if all characters are valid
         * 
         * - open brackets must be closed by the same type of brackets
         * - open brackets must be closed in the correct order
         * - every close bracket has a correponding open bracket of the same type
         */
    Stack<char> stack = new Stack<char>();
    foreach (char c in s)
    {
        switch (c)
        {
            case '(':
            case '[':
            case '{':
                stack.Push(c);
                break;
            case ')':
                if (stack.Count == 0 || stack.Pop() != '(')
                    return false;
                break;
            case ']':
                if (stack.Count == 0 || stack.Pop() != '[')
                    return false;
                break;
            case '}':
                if (stack.Count == 0 || stack.Pop() != '{')
                    return false;
                break;
        }
    }
    if (stack.Count != 0)
        return false;
    return true;
}

