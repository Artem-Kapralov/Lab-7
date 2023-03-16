using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp56
{
    internal static class ClassCreater
    {
        public static Аудитория Аудитория()
        {
            Console.WriteLine("Введите название: ");
            string название = Console.ReadLine();
            Console.WriteLine("Введите количество посадочных мест: ");
            uint количество_посадочных_мест = uint.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество окон: ");
            uint количество_окон = uint.Parse(Console.ReadLine());
            return new Аудитория(название, Сотрудник(), количество_посадочных_мест, количество_окон, Оборудование());
        }
        public static Сотрудник Сотрудник()
        {
            return new Сотрудник();
        }
        public static List<Оборудование> Оборудование()
        {
            return new List<Оборудование>();
        }
    }

    internal static class UI
    {
        public static void Print(Аудитория аудитория)
        {
            Console.WriteLine("Название: }");
            Console.WriteLine($"Сотрудник: {аудитория.Сотрудник}");
            Console.WriteLine("Количество посадочных мест: ");
            Console.WriteLine("Количество окон: ");
            Console.WriteLine($"Сотрудник: {аудитория.Оборудование}");
        }
        public static void Print(Сотрудник сотрудник)
        {

        }
        public static void Print(Оборудование оборудование)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите название класса, который хотите создать: ");
                switch (Console.ReadLine())
                {
                    case "Аудитория": UI.Print(ClassCreater.Аудитория()); break;
                    default: Console.WriteLine("Такой класс не существует"); break;
                }
            }
        }
    }
}
