namespace Algoritm_Practice.Leetcode
{
    public static class GroupAnagrams
    {
        public static IList<IList<string>> groupAnagrams(string[] strs)
        {

            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            foreach (string word in strs)
            {
                char[] chars = word.ToCharArray();
                Array.Sort(chars);
                string key = new String(chars);

                //string key = String.Concat(word.OrderBy(c => c)); gives the same output as the 3 lines above but in one line

                if (dict.ContainsKey(key))
                {
                    dict[key].Add(word);
                }
                else
                {
                    dict[key] = new List<string> { word };
                }
            }

            List<string>[] strings = dict.Values.ToArray();
            return dict.Values.ToArray();
        }
    }
}
