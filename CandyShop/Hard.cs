using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Copywright
{
    class Hard
    {
        static void Main()
        {
            #region CreationFolders
            if (Directory.Exists(@"C:\Users\Public\Documents\Lesson15")) //Перевірка чи існує папка для тесту
            {
                Console.WriteLine("Directory allready exist");
            }
            else
            {
                Directory.CreateDirectory(@"C:\Users\Public\Documents\Lesson15"); //Створення папки для тесту
            }

            if (Directory.Exists(@"C:\Users\Public\Documents\CloneLesson15")) //Перевірка чи існує папка для тесту
            {
                Console.WriteLine("Directory allready exist");
            }
            else
            {
                Directory.CreateDirectory(@"C:\Users\Public\Documents\Clone_Lesson15"); //Створення папки для тесту
            }
            #endregion

            string filePath = @"C:\Users\Public\Documents\Lesson15\worm.txt";
            string destinationPath = @"C:\Users\Public\Documents\Clone_Lesson15\MEGAworm.txt";
            string content = string.Empty;

            try
            {                
                using (var worm = File.Create(filePath)) //Створення файлу з якого копіюємо
                {
                    
                }

                Console.Write("Enter text: ");
                string contentToWrite = Console.ReadLine(); // Текст для запису у файл
                try
                {
                    File.WriteAllText(filePath, contentToWrite);
                    Console.WriteLine("Your text writed in file");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка: {ex.Message}");
                }

                using (var worm = File.Create(destinationPath)) //Створення файлу в який копіюємо
                {

                }
                
                try
                {
                    content = File.ReadAllText(filePath);     // Зчитування тексту файлу з якого копіюємо               
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка: {ex.Message}");
                }


                try
                {
                    File.WriteAllText(destinationPath, content); // Запис тексту в файл в який копіюємо
                    Console.WriteLine("Writed in file");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ERROR: {ex.Message}");
                }


                Console.WriteLine("Done");

            }

            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }



        }        
    }
}




