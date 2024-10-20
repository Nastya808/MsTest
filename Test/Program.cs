using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите дату и время по отдельности:");

        Console.Write("Введите год (1-9999): ");
        int year = DateInputHelper.ReadInput("Год", 1, 9999, Console.ReadLine());

        Console.Write("Введите месяц (1-12): ");
        int month = DateInputHelper.ReadInput("Месяц", 1, 12, Console.ReadLine());

        Console.Write($"Введите день (1-{DateTime.DaysInMonth(year, month)}): ");
        int day = DateInputHelper.ReadInput("День", 1, DateTime.DaysInMonth(year, month), Console.ReadLine());

        Console.Write("Введите час (0-23): ");
        int hour = DateInputHelper.ReadInput("Час", 0, 23, Console.ReadLine());

        Console.Write("Введите минуту (0-59): ");
        int minute = DateInputHelper.ReadInput("Минута", 0, 59, Console.ReadLine());

        try
        {
            DateTime result = DateInputHelper.CreateDateTime(year, month, day, hour, minute);
            Console.WriteLine($"Вы ввели корректную дату и время: {result}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
