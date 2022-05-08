// Demonstrate the use of Parameterized Constructor in C#.

using System;

namespace paraConstructor
{
    public class Demo
    {
        public Demo(int roll , string name)
        {
            Console.WriteLine("Roll Number : "+roll);
            Console.WriteLine("Name : "+name);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo d1 = new Demo(39, "Aditya Mahajan");
            Console.ReadLine();
        }
    }
}
