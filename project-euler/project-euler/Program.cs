namespace project_euler
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var x = 1;
            var y = 2;

            // 4613732
            var total = 0;

            while (true)
            {
                var added = (x + y);

                if (y % 2 == 0)
                {
                    total = total + y;
                }

                x = y;
                y = added;

                if (y > 4000000)
                {
                    break;
                }
            }

            Console.WriteLine("Total: {0}", total);
            Console.ReadLine();
        }
    }
}
