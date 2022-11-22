using System;

namespace natural
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0;
            for(i=1;i<=10;i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum of first 10 natural numbers is " + sum);
            Console.ReadLine();
        }
    }
}
