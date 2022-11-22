using System;

namespace largest
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter the value of a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of c");
            c = Convert.ToInt32(Console.ReadLine());
            if (a >= b && a >= c)
            {
                Console.WriteLine("The largest number is " + a);
            }
            if (b >= a && b >= c)
            {
                Console.WriteLine("The largest number is " + b);
            }
            if (c >= a && c >= b)
            {
                Console.WriteLine("The largest number is " + c);
            }
            Console.ReadLine();
        }
        }
}
