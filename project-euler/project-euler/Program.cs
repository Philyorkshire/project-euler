namespace project_euler
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 999);

            // 233168
            var total = 0;

            foreach (var number in numbers)
            {
                if (number % 3 == 0 || number % 5 == 0)
                {
                    total = number + total;
                }
            }

            Console.WriteLine("Total: {0}", total);
            Console.ReadLine();
        }
    }
}
