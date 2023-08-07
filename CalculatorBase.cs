using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace declaration
namespace CalculatorApplication       //Namespace: used to declare a scope that contains a set of related objects
{
    //Base Class
    public abstract class CalculatorBase     //Abstract base class is created
    {
        public abstract void Add(int x, int y);         // Add abstract method created 
        public abstract void Sub(int x, int y);         // Subtract abstract method created 
        public abstract void Mul(int x, int y);         // Multiply abstract method created 
        public void Div(int x, int y)                   // Division (non-abstract) method created
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(" Division is : " + (x / y));            //Print x/y
            Console.WriteLine("-------------------------");

        }
    }
}
