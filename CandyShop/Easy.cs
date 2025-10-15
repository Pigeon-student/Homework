using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShop
{
    class Homework
    {
        static void Main2() // <-- Rename to Main to run!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        {
            Console.Write("Enter path to file: ");             //Зчітування шляху до файлу ЯКИЙ копіюємо
            string userPath = $@"{Console.ReadLine()}";

            if (File.Exists(userPath))                          //Перевірка чи існує файл
            {
                Console.WriteLine("File exist");
            }
            else
            {
                Console.WriteLine("File does'nt exxist yet");
            }

            Console.Write("Enter path to copy: ");              //Зчітування шляху КУДИ копіюємо
            string destinationPath = $@"{Console.ReadLine()}";

            File.Copy(userPath, destinationPath);               //Власне копіювання файлу
            Console.WriteLine("Файл скопійовано.");


            if (File.Exists(destinationPath))                   //Перевірка чи скопіювався файл
            {
                Console.WriteLine("File copyfied");
                //Console.WriteLine(userPath);
            }
            else
            {
                Console.WriteLine("File does'nt copyfied");
                //Console.WriteLine(userPath);
            }

        }


    }
}

