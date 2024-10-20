public class DateInputHelper
{
    public static int ReadInput(string prompt, int min, int max, string input)
    {
        int value;
        if (int.TryParse(input, out value) && value >= min && value <= max)
        {
            return value;
        }
        throw new ArgumentException($"Некорректное значение для {prompt}. Ожидался диапазон {min}-{max}.");
    }

    public static DateTime CreateDateTime(int year, int month, int day, int hour, int minute)
    {
        if (day > DateTime.DaysInMonth(year, month))
        {
            throw new ArgumentException("Некорректный день для данного месяца.");
        }
        return new DateTime(year, month, day, hour, minute, 0);
    }
}