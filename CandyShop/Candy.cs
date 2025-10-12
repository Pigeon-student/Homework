using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShop
{
    /// <summary>
    /// Основний базовий класс
    /// </summary>
    public class Candy
    {
        private string name;
        private decimal basePrice;

        public Candy(string name, decimal price) // Конструктор базового класу
        {
            this.name = name;
            basePrice = Convert.ToDecimal(price);
        }

        public virtual void Info() // Метод для виведення інформації
        {
            Console.Write($"\nНазва: {name}, Ціна: {basePrice}$ ");
        }

        public virtual void Price() // Метод для виведення ціни
        {
            Console.Write($"\nЦіна: {basePrice}$\n");
        }

    } //Оригінал, базовий класс




    /// <summary>
    /// Похідний класс з доданим значенням "шматочкі"
    /// </summary>
    public class Gum : Candy
    {
        private decimal basePrice;
        private int pieces;
        public Gum(string name, decimal price, int pieces) : base(name, price) // Передаємо в базовий тип назву та ціну
        {
            this.pieces = pieces;
            this.basePrice = Convert.ToDecimal(price);
        }

        public override void Info() // Перевизначаємо метод Info
        {
            base.Info();
            Console.Write($"Кількість: {pieces}шт.\n");
        }
        public override void Price() // Метод для виведення ціни в залежності від кількості
        {
            Console.Write($"\nЦіна: {basePrice * pieces}$\n");
        }
    } // Похідний класс




    /// <summary>
    /// Похідний класс з доданим значенням "вага"
    /// </summary>
    public class Chocolate : Candy
    {
        private decimal basePrice;
        private int weight;
        public Chocolate(string name, decimal price, int weight) : base(name, price)
        {
            this.weight = weight;
            this.basePrice = Convert.ToDecimal(price);
        }
        public override void Info()
        {
            base.Info();
            Console.Write($"В наявності: {weight}кг\n");
        }
        public override void Price() // Метод для виведення ціни залежно від ваги
        {
            Console.Write($"\nЦіна: {basePrice * weight}$\n");
        }
    } // Похідний класс




    /// <summary>
    /// Похідний класс з доданим значенням "розмір"
    /// </summary>
    public class Lollipop : Candy
    {
        private decimal basePrice;
        private int size;
        public Lollipop(string name, decimal price, int size) : base(name, price)
        {
            this.size = size;
            this.basePrice = Convert.ToDecimal(price);
        }
        public override void Info()
        {
            base.Info();
            Console.Write($"Розмір: {size}см\n");
        }
        public override void Price() // Метод для виведення ціни в залежності від розміру цукерки
        {
            Console.Write($"\nЦіна: {basePrice * size}$\n");
        }
    } // Похідний класс


}

