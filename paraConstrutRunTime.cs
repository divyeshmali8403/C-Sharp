// Demonstrate the  use of Parameterized Constructor at Run Time.

using System;

namespace paraConstructorRun
{
    public class Demo
    {
        int roll;
        string name; 

        public  Demo(int roll , string name)
        {
            this.roll = roll;
            this.name = name;
        }

        public void Show()
        {
            Console.WriteLine("Roll Number : " + roll);
            Console.WriteLine("Name : " + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int roll;
            string name;

            Console.WriteLine("Enter Roll Number");
            roll = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name Number");
            name = Console.ReadLine();
            Demo d1 = new Demo(roll, name);
            d1.Show();

            Console.ReadLine();
        }
    }
}
