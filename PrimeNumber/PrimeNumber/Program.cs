using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number to check its prime or not : ");
            int Num = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            for (int i = 1; i <= Num; i++)
            {
                if (Num % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
                Console.WriteLine("not a Prime Number " + Num);
            else
                Console.WriteLine(" Prime Number " + Num);
        }
    }
}
