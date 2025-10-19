using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace FileManager
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            var userInput = Console.ReadLine();

            Console.Write($"Is this number? ");
            Thread.Sleep(4000);

            try
            {
                Action input = new Action();
                Console.Write($"{input.CheckingIsInputNumber(userInput)}!");              

            }
            catch (FormatException)
            {
                throw new FormatException("ERROR! Some error somewhere in progaram!");
            }

        }
    }
}




