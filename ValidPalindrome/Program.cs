using System;
using System.Text.RegularExpressions;

namespace ValidPalindrome
{
    class Program
    {
        public static void Main(string[] args)
        {
            string s = "Marge, let's \"[went].\" I await {news} telegram.\"";
            Console.WriteLine(IsPalindrome(s));
        }

        public static bool IsPalindrome(string s)
        {
            Regex regex = new ("[^a-zA-Z0-9]");
            s = regex.Replace(s.ToLower(), string.Empty);
            for(int i = 0; i < (int)(s.Length) / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}