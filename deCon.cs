// Demonstrate use of Default Constructor in C#.

using System;

namespace defaultConstructor
{
    public class Demo
    {
        int a, b, c;

        // Default Or Non-Parameterized Constructor
        public Demo()
        {
            Console.Write("Enter Value of A : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Value of B : ");
            b = Convert.ToInt32(Console.ReadLine());

        }

        public void show()
        {
            c = a + b;
            Console.WriteLine("Sum Of A and B Is : " + c);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Demo d1 = new Demo();
            d1.show();
            Console.ReadLine();
        }
    }
}
