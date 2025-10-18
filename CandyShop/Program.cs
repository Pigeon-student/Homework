using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace FileManager
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            var userInput = Console.ReadLine();
            int firstNumber;

            if (!int.TryParse(userInput, out firstNumber))
            {
                Console.WriteLine("Wrong input");
            }

            Console.Write("Enter second number: ");
            var secondNumber = 1;  

            try
            {
                secondNumber = Convert.ToInt32(Console.ReadLine());

                if (secondNumber == 0)
                {
                    throw new DivideExeption("You cant divide to zero, stupid");
                }
            }
            catch
            {
                Console.WriteLine("Wrong input occurred!");
            }

            try
            {
                Console.WriteLine($"Result is: {firstNumber / secondNumber} ");
            }
            catch (DivideByZeroException eh)
            {
                Console.WriteLine(eh.Message);
            }

            finally
            {
                Console.WriteLine("\nIt was a pleasure to work with you\n");
            }


            //Second variant:

            Console.WriteLine("Second variant: ");

            Action actionDivide = new Action();
            Console.Write(actionDivide.Divide(firstNumber, secondNumber));






        }
    }
}




