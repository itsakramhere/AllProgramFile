using System;

namespace ConsoleApp4
{
    class Program
    {
        public static bool IsPalindrome(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }
        static void Main(string[] args)
        {
            //string val = "Hero";
            //bool result = IsPalindrome(val);
            //Console.WriteLine(result);

            Console.WriteLine("Enter the word of string : ");
            string val = Console.ReadLine();
            bool result = IsPalindrome(val.Trim());
            if (result)
            {
                Console.WriteLine(val+" is palindrome");
            }
            else
            {
                Console.WriteLine(val +" is not palindrome");
            }
       
        }
    }
}
