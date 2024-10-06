using System;

class Program
{
    static void Main()
    {
        // Ввод четырехзначного числа
        Console.Write("Введите четырехзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Проверка, является ли число четырехзначным
        if (number < 1000 || number > 9999)
        {
            Console.WriteLine("Число должно быть четырехзначным.");
            return;
        }

        // Вычисление произведения цифр
        int product = 1;
        while (number > 0)
        {
            product *= number % 10;
            number /= 10;
        }

        // Вывод результата
        Console.WriteLine("Произведение цифр: " + product);
    }
}
