using System;

namespace pattern1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("n:");

            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= n; i++)

            {

                for (int j = 1; j <= n - i; j++)

                {

                    Console.Write(" ");

                }

                for (int j = 1; j <= 2 * i - 1; j++)

                {

                    Console.Write("*");

                }

                Console.Write("\n");

            }

            Console.ReadLine();

        }
    }
    }

