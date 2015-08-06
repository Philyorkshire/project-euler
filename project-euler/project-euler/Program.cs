namespace project_euler
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            const long number = 600851475143;

            Console.WriteLine("Largest Prime Factor: {0}", largestPrimeFactor(number));
            Console.ReadLine();
        }

        public static long largestPrimeFactor(long n)
        {
            var sqrt = (long)Math.Ceiling(Math.Sqrt(n));

            long largest = -1;

            for (long i = 2; i <= sqrt; i++)
            {
                if (n%i != 0) continue;

                var test = largestPrimeFactor(n / i);
                if (test > largest)
                {
                    largest = test;
                }
            }

            return largest != -1 ? largest : n;
        }
    }
}
