// 3 : Write a program to show use of Looping Constructs.

// By Aditya C Mahajan

using System;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {

            // While Loop
            Console.WriteLine("1.While Loop \n");

            int wnum = 1;

            while (wnum < 6)
            {
                Console.WriteLine(wnum + " Hello ");
                wnum++;
            }

            Console.WriteLine();

            Console.WriteLine("2. Do While Loop \n");

            int dwnum = 1;

            do
            {
                Console.WriteLine(dwnum + " Hello ");
                dwnum++;
            } while (dwnum < 6);

            Console.WriteLine();

            Console.WriteLine("3. For Loop ");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + " Hello ");
            }

        }
    }
}