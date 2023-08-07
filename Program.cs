using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace declaration
namespace CalculatorApplication
{
    public class Program
    {
        public static void Main(string[] args)                                          //Main Method 
        {

            Console.WriteLine("-------------------------");
            Console.WriteLine("-------Calculator--------");
            Console.WriteLine("-------------------------");
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter First Digit : ");
                    int x = Convert.ToInt32(Console.ReadLine());                         //Console.WriteLine("First Digit: " + x);
                                                                                
                    Console.WriteLine("Enter Second Digit : ");                          //Console.WriteLine("Second Digit: " + y);
                    int y = Convert.ToInt32(Console.ReadLine());

                    if ((x < 100 && x > 9) && (y < 100 && y > 9))                        //Two-digits argument restriction
                    {
                        Console.WriteLine("-------------------------");
                        CalculatorBase cal = new Calculator();                           //Create calculator class object    
                            //Call Abstract method
                            cal.Add(x, y);
                            cal.Sub(x, y);
                            cal.Mul(x, y);
                            //Call Regular method (non-abstract method)
                            cal.Div(x, y);

                          Console.WriteLine("-------------------------");
                          Console.ReadLine();                                           //Reads the next line, prevents application to close
                        
                    }
                    else
                    {
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("The interger value is resticeted for 2 digit numbers only. Please check First/Second digit values.");
                        Console.WriteLine("Hint: Enter values between 10-99");
                        Console.WriteLine("-------------------------------");

                    }
                    
                }
                catch (Exception e)                                                       // Invalid input exception error
                {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine($"{"Invalid data: " + e.Message}");
                    Console.WriteLine("-------------------------------");

                }
            }
        }
    }
}
