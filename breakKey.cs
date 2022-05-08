// Demonstrate use of break statement in c#

using System;

namespace breakStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int num , i;
            Console.WriteLine("Enter a Number : ");
            num = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < num; i++)
            {
                Console.WriteLine(i);
                if (i == num / 2)
                {
                    break;
                }
            }
            Console.WriteLine("Loop break at " + i);
            Console.ReadLine();
        }
    }
}
