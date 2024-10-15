using System.Text;

namespace Algoritm_Practice.Codewars
{
    public static class BreakcamelCase
    {
        public static string BreakCamelCase(string str)
        {
            // complete the function

            StringBuilder sb = new StringBuilder();

            foreach (var item in str)
            {
                if (Char.IsUpper(item))
                    sb.Append(' ');
                sb.Append(item);
            }

            return sb.ToString();

        }
    }
}
