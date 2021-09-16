using System;

namespace Fibonacci_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number : ");
            int N = Convert.ToInt32(Console.ReadLine());
            int N1 = 0;
            int N2 = 1;
            int sumofnumbers = 0;

            Console.WriteLine("Fibonacci Series: ");
            Console.WriteLine("1 : {0}", N1);
            Console.WriteLine("2 : {0}", N2);
            for (int i = 0; i <= N - 3; i++)
            {
                sumofnumbers = N1 + N2;
                N1 = N2;
                N2 = sumofnumbers;

                Console.WriteLine((i + 3) + " : " + sumofnumbers);
            }
            }
    }
}
