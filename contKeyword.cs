// Demonstrate use of continue statement in c#

using System;

namespace continueStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i , bnum;
            Console.WriteLine("Enter a Number : ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value to skip : ");
            bnum = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < num; i++)
            {
               
                if (i == bnum)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            
            Console.ReadLine();
        }
    }
}
