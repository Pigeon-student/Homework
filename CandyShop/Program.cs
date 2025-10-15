using System.IO;

namespace Copywright
{
    class Program
    {
        static void Main()
        {
            Console.Write( "Enter path to file: ");             //Зчітування шляху до файлу ЯКИЙ копіюємо
            string userPath = $@"{Console.ReadLine()}";

            if (File.Exists(userPath))                          //Перевірка чи існує файл
            {
                Console.WriteLine("File exist");
                //Console.WriteLine(userPath);
            }
            else
            {
                Console.WriteLine("File does'nt exxist yet");
                //Console.WriteLine(userPath);
            }


            Console.Write("Enter path to copy: ");              //Зчітування шляху КУДИ копіюємо
            string destinationPath = $@"{Console.ReadLine()}";


            File.Copy(userPath, destinationPath);               //Власне копіювання файлу
            Console.WriteLine("Файл скопійовано.");


            if (File.Exists(destinationPath))                   //Перевірка чи скопіювався файл
            {
                Console.WriteLine("File exist");
                //Console.WriteLine(userPath);
            }
            else
            {
                Console.WriteLine("File does'nt exxist yet");
                //Console.WriteLine(userPath);
            }





        }





    }
}




