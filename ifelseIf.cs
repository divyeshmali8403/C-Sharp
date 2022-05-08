* 6 : Write a program  to display student grade using if-else-if-else
 , get user input percentage with do while loop .

// By Aditya C Mahajan

using System;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {

            string contn;

            do {
                int per;
                
                Console.WriteLine("Enter Your Percentage : ");
                per = Convert.ToInt32(Console.ReadLine());

                //  Console.WriteLine(per);

                if (per >= 85 && per <= 100)
                {
                    Console.WriteLine(" Grade : A ");
                }
                else if (per >= 70 && per < 85)
                {
                    Console.WriteLine(" Grade : B ");
                }

                else if (per >= 55 && per < 70)
                {
                    Console.WriteLine(" Grade : C ");
                }

                else if (per >= 36 && per < 55)
                {
                    Console.WriteLine(" Grade : D ");
                }
                else if (per >= 0 && per < 36)
                {
                    Console.WriteLine(" FAIL !!! ");
                }
                else
                {
                    Console.WriteLine("Please Enter Valid Percentage");
                }

                Console.WriteLine("Do You want to continue press Y : ");
                contn =  Console.ReadLine();
            
            }while(contn == "Y");

              Console.ReadLine();
        }
    }
}