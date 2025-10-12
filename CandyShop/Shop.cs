using System.Text;
using System.Xml.Linq;

namespace CandyShop
{
    class Shop
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;


            List<Candy> candies = new List<Candy>
             {
              new Candy("Кьортіс", 0.5m),
              new Gum("Ґаммі", 10.5m, 10),
              new Chocolate("Посередній", 0.01m, 100),
              new Lollipop("Венздей", 25.0m, 17),

             };

            Console.WriteLine("Можна ДОДАТИ нову цукерку, подивитися ІНФО по кожній та по ВСІх одразу поки не ВТОМИВСЯ\n");
            bool isTired = false;


            while (!isTired)
            {
                Console.Write("Введіть дію: ");
                string action = Console.ReadLine().ToLower();
                if (action == "інфо")
                {
                    //Виведення інформації по кожній цукерці (МОЗОК ВІДМОВЛЯЄТЬСЯ ПРАЦЮВАТИ)
                }
                else if (action == "всі")
                {
                    PrintCandyList();
                   
                }
                else if (action == "додати")
                {
                    NewCandy();                    
                }
                else if (action == "втомився")
                {
                    isTired = true;
                }
                else
                {
                    Console.WriteLine("Невідома дія");
                    continue;
                }

            }



            //Метод для виведення списку цукерок
            void PrintCandyList()
            {
                foreach (var candy in candies)
                {
                    candy.Info();
                }
            }

            //Дуже дивний метод, але я не знаю як зробити краще
            void NewCandy()
            {
                Console.WriteLine("Enter name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter price: ");
                decimal price = Convert.ToDecimal(Console.ReadLine());
                AddCandyToList(candies, name, price);
            }
            static void AddCandyToList(List<Candy> candies, string name, decimal price)
            {
                candies.Add(new Candy(name, price));
            }




        }
    }
}




