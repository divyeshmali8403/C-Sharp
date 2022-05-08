/* 5 : Write a program for Demonstrate Arithmetic operator 
with user input , with using loop for execute multiple times.

// By Aditya C Mahajan

using System;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {

int choice = 1;
void LoopFun() {
            
int num1 , num2, sum , sub , mul , div;


Console.WriteLine("Enter a Number : ");
num1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Enter a Number : ");
num2 = Convert.ToInt32(Console.ReadLine());

sum = num1 + num2;
Console.WriteLine(num1+" + "+num2+" : "+sum);


sub = num1 - num2;
Console.WriteLine(num1+" - "+num2+" : "+sub);

mul = num1 * num2;
Console.WriteLine(num1+" x "+num2+" : "+mul);


div = num1 / num2;
Console.WriteLine(num1+" / "+num2+" : "+div);

}
while(choice > 0) {
Console.WriteLine("Enter 1 : for Run again | Enter 0 : for exit");
 choice = Convert.ToInt32(Console.ReadLine());
 LoopFun();
}




        }
    }
}