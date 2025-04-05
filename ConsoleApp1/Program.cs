using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        //Задание №1

        Console.WriteLine("Привет, мир!");

        //Задание №2

        Console.WriteLine("Пожалуйста, введите число!");
        int number_user = Convert.ToInt32(Console.ReadLine());
        if(number_user % 2 == 0)
        {
            Console.WriteLine("Ваше число чётное!");
        } else {
            Console.WriteLine("Ваше число нечётное");
        }

        //Задание №3

        Console.WriteLine("Таблица умножения на 5:");
        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{i} * 5 = {i * 5}");
        }

        //Задание №4

        SayHello("Иван");
        SayHello("Дима");
        SayHello("Андрей");
        SayHello("Настя");
        SayHello("Маша");
        SayHello("Алина");
        static void SayHello(string name)
        {
            Console.WriteLine($"Привет, {name}!");
        }

        //Задание №5

        Person person = new Person { name = "Дима", age = 23 };
        person.PrintInfo();
    }
}

//Задание №5

class Person
    {
        public string name;
        public int age;

        public void PrintInfo()
        {
            Console.WriteLine($"Имя: {name}, Возраст: {age}");
        }
    }