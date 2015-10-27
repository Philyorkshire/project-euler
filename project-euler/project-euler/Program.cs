namespace project_euler
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var nums = Enumerable.Range(1, 100).Select(Convert.ToDouble).ToList();

            var sqrSum = nums.Sum(n => n*n);
            var rangeSum = nums.Sum() * nums.Sum();

            var result = rangeSum - sqrSum;

            Console.WriteLine("Sum square difference: {0}", result);
            Console.ReadLine();
        }
    }
}
