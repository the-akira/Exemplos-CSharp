using System;
using System.Linq;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Método 1 (madam): {IsPalindrome("madam")}");
            Console.WriteLine($"Método 1 (music): {IsPalindrome("music")}");
            Console.WriteLine($"Método 2 (madam): {IsPalindrome("madam")}");
            Console.WriteLine($"Método 2 (music): {IsPalindrome("music")}");
        }

        public static bool IsPalindrome(string str)  
        {
            return str.SequenceEqual(str.Reverse());
        }

        public static bool PalindromeTest(string str)
        {
            int length = str.Length;
            for (int i = 0; i < length/2; i++)
            {
                if (str[i] != str[length - i - 1])
                    return false;
            }
            return true;
        }
    }
}