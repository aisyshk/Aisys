using System.Text;

namespace Aisys.Utilities
{
    public static class StringUtility
    {
        public static string Reverse(this string str)
        {
            char[] StringCharacters = str.ToCharArray();
            Array.Reverse(StringCharacters);

            return new string(StringCharacters);
        }

        public static string RemoveCharacter(this string str, char character)
        {
            char[] StringCharacters = str.ToCharArray();
            var splitString = string.Join("", StringCharacters).Split(character);

            StringBuilder sb = new StringBuilder();
            foreach (var st in splitString)
            {
                sb.Append(st);
            }

            return new string(sb.ToString());
        }

        public static string RemoveWord(this string str, string word)
        {
            return new string(str.Replace(word, "").ToString());
        }
    }
}