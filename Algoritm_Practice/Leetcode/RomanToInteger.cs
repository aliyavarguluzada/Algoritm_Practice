namespace Algoritm_Practice.Leetcode
{
    public static class RomanToInteger
    {
        public static int RomanToInt(string s)
        {
            int result = 0;

            for (int i = 0; i < s.Length-1; i++)
            {
                if (getInt(s[i]) < getInt(s[i + 1]))
                    result -= getInt(s[i]);
                else
                    result += getInt(s[i]);

            }

            return result + getInt(s[s.Length - 1]);
        }
        private static int getInt(char s)
        {
            Dictionary<string, int> values = new Dictionary<string, int>() {
                                                                { "I", 1 },
                                                                { "V",5},
                                                                { "X",10},
                                                                { "L",50},
                                                                { "C",100},
                                                                { "D", 500},
                                                                { "M",1000}  };

            switch (s)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;

                default:
                    return -1;
            }
        }
    }

}
