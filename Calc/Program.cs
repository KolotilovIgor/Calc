using System;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("Нажмите Enter для выхода.");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Addition();
                    break;
                case "2":
                    Subtraction();
                    break;
                case "3":
                    Multiplication();
                    break;
                case "4":
                    Division();
                    break;
                case "":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Неверный ввод. Попробуйте снова.");
                    break;
            }
        }
    }

    static void Addition()
    {
        Console.WriteLine("Введите первое число:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = num1 + num2;
        Console.WriteLine($"Результат сложения: {result}");
    }

    static void Subtraction()
    {
        Console.WriteLine("Введите уменьшаемое:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите вычитаемое:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = num1 - num2;
        Console.WriteLine($"Результат вычитания: {result}");
    }

    static void Multiplication()
    {
        Console.WriteLine("Введите первый множитель:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второй множитель:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = num1 * num2;
        Console.WriteLine($"Результат умножения: {result}");
    }

    static void Division()
    {
        Console.WriteLine("Введите делимое:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите делитель (не ноль):");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (num2 == 0)
        {
            Console.WriteLine("Деление на ноль невозможно.");
        }
        else
        {
            double result = num1 / num2;
            Console.WriteLine($"Результат деления: {result}");
        }
    }
}