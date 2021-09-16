using System;

namespace PerfectNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;
            Console.Write("enter the Number");
            int Number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < Number; i++)
            {
                if (Number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == Number)
                Console.WriteLine("Entered number is a perfect number");
            else
                Console.WriteLine(" Entered number is not a perfect number");
        }
    }
}
