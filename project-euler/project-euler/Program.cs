namespace project_euler
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var palindrome = 0;

            for (var i = 999; i > 0; i--)
            {
                for (var x = 0; x < 999; x++)
                {
                    var multiplied = (x*i);
                    if (IsPalindrome(multiplied) && multiplied > palindrome) palindrome = multiplied;
                }
            }

            Console.WriteLine("Largest Palindrome: {0}", palindrome);
            Console.ReadLine();
        }

        public static bool IsPalindrome(int num)
        {
            var reversed = new string(num.ToString().Reverse().ToArray());
            return reversed == num.ToString();
        }
    }
}
