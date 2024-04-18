using System.Text.RegularExpressions;

namespace Task2
{
    internal class StrFunc
    {
        public static string DeleteAllPunctuation(string str)
        {
            string[] chars = new string[] { ",", ".", "!", "?" };
            foreach (string c in chars)
            {
                str = str.Replace(c, string.Empty);
            }
            return str;
        }
        public static string DeleteEmptySpace(string str)
        {
            return Regex.Replace(str, @"\s+", " ");
        }
        public static string AllToUp(string str)
        {
            return str.ToUpper();
        }
        public static string AddSymbols(string str)
        {
            return "////" + str + "////";
        }
        public static string AddCount(string str)
        {
            string[] strings = str.Split(' ');
            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] += $"[{strings[i].Length}]";
            }
            return string.Join(' ', strings);
        }
    }
}
