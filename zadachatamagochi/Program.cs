using System;
using zadachatamagochi;

namespace Tamagochi
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat(Console.ReadLine(), Console.ReadLine());
            Cat dog = new Cat();
            Cat.Fight(cat, dog);
            Cat.Info(dog);
            Cat.Meow(dog);
            Fruit Apple = new Fruit { heath = 10, type = "яблоко" };
            Cat.DoMeal(dog, Apple);
            Cat.Info(dog);

        }
    }
}