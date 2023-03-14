using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadachatamagochi
{
    public struct Fruit
    {
        public int heath;
        public string type;
    }
    class Cat
    {
        private string name;
        private string color;
        private int health;

        public Cat(string name = "Пушок", string color = "серый")
        {
            this.name = name;
            this.color = color;
            health = 50;
        }
        public static void Meow(Cat a)
        {
            Console.WriteLine("Мяу");
        }
        public void Eat(Fruit f)
        {
            Console.WriteLine($"Кошка съела {f.type}.{f.heath} Здоровья");
        }
        public static void DoMeal(Cat c, Fruit f)
        {
            c.Eat(f);
            c.health = c.health + f.heath;
        }
        public static void LapkiCarapki(Cat a)
        {
            Random rnd = new Random();
            if (rnd.Next(1, 51) > 70)
            {
                int damage = 15;
                a.health -= damage;
            }
            else
            {
                int damage = rnd.Next(1, 8);
                a.health -= damage;
            }
        }
        public static void Kus(Cat a)
        {
            Random rnd = new Random();
            if (rnd.Next(1, 101) > 90)
            {
                int damage = 20;
                a.health -= damage;
            }
            else
            {
                int damage = rnd.Next(1, 5);
                a.health -= damage;
            }
        }
        public static void Fight(Cat a, Cat b)
        {
            Console.WriteLine("Что сделать? 1. Не играть, 2. Не кормить, 3. Отменить");
            int u = int.Parse(Console.ReadLine());
            switch (u)
            {
                case 1:
                    Cat.LapkiCarapki(b);
                    break;
                case 2:
                    Cat.Kus(b);
                    break;
                default:
                    break;
            }

        }
        public static void Info(Cat a)
        {
            Console.WriteLine($"{a.name}, {a.color}, {a.health}");
        }


    }
}
