using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace declaration
namespace CalculatorApplication
{
    //Derived Class
    class Calculator : CalculatorBase       // Inherit abstract base class (CalculatorBase)
    {
        public override void Add(int x, int y)                      // Inherit abstract class method for Add() 
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(" Addition is : " + (x + y));     // Print x+y
            Console.WriteLine("-------------------------");
        }
        public override void Sub(int x, int y)                      // Inherit abstract class method for Sub()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(" Subtraction is : " + (x - y));    //Print x-y
            Console.WriteLine("-------------------------");
        }
        public override void Mul(int x, int y)                     // Inherit abstract class method for Mul()        
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(" Multiplication is : " + (x * y));   //Print x*y
            Console.WriteLine("-------------------------");
        }
       
    }
}
