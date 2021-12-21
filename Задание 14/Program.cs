using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal;
            Dog dogname = new Dog("Собака");
            Cat catname = new Cat("Кошка");
            Console.Write(" Введите вид животного: 1 - Собака, 2 - Кошка : ");
            string nameNumber = Console.ReadLine();
            if (nameNumber is "1")
            {
                string name = "Собака";
                animal = dogname;
                animal.Showinfo(name);
            }
            else
            {
                if (nameNumber is "2")
                {
                    string name = "Кошка";
                    animal = catname;
                    animal.Showinfo(name);
                }
                else
                {
                    Console.WriteLine(" Ошибка!");
                }
            }
            Console.ReadKey();
        }
        abstract class Animal
        {
            public string name;
            public abstract string Name { get; set; }
            public Animal(string name)
            {
                Name = name;
            }
            public abstract void Say();
            public void Showinfo(string name)
            {
                Console.WriteLine(name);
                Say();
            }
        }
        class Dog : Animal
        {
            public override string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = "Собака";
                }
            }
            public Dog(string name) : base(name)
            {
                Name = name;
            }
            public override void Say()
            {
                Console.WriteLine(" Гав!");
            }
        }
        class Cat : Animal
        {
            public override string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = "Кошка";
                }
            }
            public Cat(string name) : base(name)
            {
                Name = name;
            }
            public override void Say()
            {
                Console.WriteLine(" Мяу!");
                return;
            }
        }
    }
}