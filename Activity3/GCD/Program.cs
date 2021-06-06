using System;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 400;
            int number2 = 85;
            Console.WriteLine($"Calculating the GCD for numbers {number1} and {number2}. \n");
            int answer = gcd(number1, number2);
            Console.WriteLine("\nThe GCD of {0} and {1} is {2}.", number1, number2, answer);
        }

        static int gcd(int n1, int n2)
        {

            if (n2 == 0)
            {
                return n1;
            }
            else
            {
                Console.WriteLine("Calculating...\n Remainder is {0}", n1 % n2);
                return gcd(n2, n1 % n2);
            }
        }
    }
}
