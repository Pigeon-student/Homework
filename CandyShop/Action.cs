using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public class Action
    {
        
        public int Divide(int firstNumber, int secondNumber)
        {            
            try
            {               
                try
                {
                    return firstNumber / secondNumber;
                }
                catch (DivideByZeroException)
                {
                    Console.Write("Cannot divide by zero. Result: ");
                    return 0;                    
                }
            }
            catch (DivideByZeroException)
            {
                Console.Write("Cannot divide by zero. Result: ");
                return 0;
            }
        }       

        public double Divide(double firstNumber, double secondNumber)
        {
            try { 
                firstNumber = Convert.ToDouble(firstNumber);
                secondNumber = Convert.ToDouble(secondNumber);
               
                try
                {
                    return firstNumber / secondNumber;
                }
                catch (DivideByZeroException)
                {
                    Console.Write("Cannot divide by zero. Result: ");
                    return 0;
                }
            }
            catch (FormatException)
            {
                Console.Write("Invalid format. Result: ");
                return 0;
            }
           
        }
    }
}
