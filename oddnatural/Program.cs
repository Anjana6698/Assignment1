using System;

namespace oddnatural
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            Console.WriteLine("n:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("odd numbers are:");
            for (int i = 1; i <= n; i = i + 2)
            {
                Console.WriteLine(i);
                sum = sum + i;
            }
            Console.WriteLine("The sum of the " + n + " terms of odd natural numbers is: " + sum);
            Console.ReadLine();
        }
    }
    }

