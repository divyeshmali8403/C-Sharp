
//Write a program to show use of different operators.

// By Aditya C Mahajan

using System;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {

            // Arithmetic Operators

            Console.WriteLine("1. Arithmetic Operators");
            int num1, num2;

            Console.WriteLine("Enter a number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            Console.WriteLine("Addition (+) : " + sum);

            int sub = num1 - num2;
            Console.WriteLine("Substraction (-) : " + sub);

            int div = num1 / num2;
            Console.WriteLine("Division (/): " + div);

            int mul = num1 * num2;
            Console.WriteLine("Multiplication (x) : " + mul);

            int mod = num1 % num2;
            Console.WriteLine("Modulus (%) : " + mod);


           Console.WriteLine();

            // Logical Operators
            Console.WriteLine("2. Logical Operators");
            bool val1 = true, val2 = false;
            bool result;

            Console.WriteLine(" Value1 : " + val1 + " Value2 : " + val2);

            result = val1 && val2;

            Console.WriteLine("Logical And (&&) : " + result);


            result = val1 || val2;

            Console.WriteLine("Logical Or (||) : " + result);


            result = !val1;

            Console.WriteLine("Logical Not (!) : " + result);

            Console.WriteLine();

           // Assignment Operators

           Console.WriteLine("3. Assignment Operators");

           Console.WriteLine("Enter a Number : ");
           int numAss = Convert.ToInt32(Console.ReadLine());

          numAss += 10;
          Console.WriteLine("Add Assignment ( numAss += 10 ) : "+numAss);
         
          numAss -= 10;
          Console.WriteLine("Subtract Assignment ( numAss -= 10 ) : "+numAss);

          numAss *= 10;
          Console.WriteLine("Multiply Assignment ( numAss *= 10 ) : "+numAss);

          numAss /= 10;
          Console.WriteLine("Division Assignment ( numAss /= 10 ) : "+numAss);

          numAss %= 10;
          Console.WriteLine("Modulus Assignment ( numAss %= 10 ) : "+numAss);

          Console.WriteLine();

           // Conditional Operator

         Console.WriteLine("4.Conditional Operator or Ternary Operator");

         int x = 10 , y = 20;
         int res1 , res2;

         res1 = x > y ? x : y;

         Console.WriteLine("Result : "+res1);

          res2 = x < y ? x : y;
              
         Console.WriteLine("Result : "+res2);
        }
    }
}
