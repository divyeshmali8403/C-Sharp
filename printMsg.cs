//Write a program to print "Teach One, Each One, Tree One" given number of times.

// By Aditya C Mahajan

using System;

namespace First {
    class Program {
        static void Main(string[] args) {

        int count;
        Console.WriteLine("Enter Number : ");
        count = Convert.ToInt32(Console.ReadLine());

        for(int i = 0; i < count; i++) {
            Console.WriteLine("Teach One, Each One, Tree One");
        }

        }
    }
}