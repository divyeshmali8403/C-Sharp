 4 : Write a program for given two integer values return 
their sum . unless the two values are the same then 
return double of their sum with using function. 

// By Aditya C Mahajan

using System;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {

   
      int num1 , num2;
      Console.WriteLine("Enter a Number : ");
      num1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter a Number : ");
      num2 = Convert.ToInt32(Console.ReadLine());

      int sum = ( sum_double(num1 , num2));

      Console.WriteLine(sum);
        
      int sum_double(int fnum ,int snum) {

        if(fnum == snum) { 
           return (fnum + snum)*2;
        }
        else {
           return fnum + snum;
        }
      
    }
  
        
        }
    
    }
}