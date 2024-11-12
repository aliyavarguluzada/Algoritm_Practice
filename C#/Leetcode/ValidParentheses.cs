namespace C_.Leetcode
{
    public static class ValidParentheses
    {
        public static bool IsValid(string s)
        {

            if (s.Length % 2 != 0)
                return false;

            Stack<char> stack = new Stack<char>();


            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' && stack.Count != 0 && stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else if (c == ']' && stack.Count != 0 && stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else if (c == '}' && stack.Count != 0 && stack.Peek() == '{')
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }

            };

            if (stack.Count == 0)
                return true;

            return false;
        }

        public static bool IsValidLT(string s)
        {
            Dictionary<char, char> pairs = new Dictionary<char, char>()
            {
                {'(', ')'},
                {'[', ']'},
                {'{', '}'}
            };

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {

                if (pairs.ContainsKey(s[i])) { stack.Push(pairs[s[i]]); }
                else
                {
                    if (stack.Count() == 0) { return false; }

                    if (stack.Pop() != s[i]) { return false; }
                }
            }
            return stack.Count == 0;
        }
    }
}
