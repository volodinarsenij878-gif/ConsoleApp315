using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program155
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Номер месяца (1–12): ");
            if (!int.TryParse(Console.ReadLine(), out int m))
            {
                Console.WriteLine("Ошибка: введите целое число.");
                return;
            }

            string season;
            if ((m == 12) || (m >= 1 && m <= 2))
                season = "Зима";
            else if (m >= 3 && m <= 5)
                season = "Весна";
            else if (m >= 6 && m <= 8)
                season = "Лето";
            else if (m >= 9 && m <= 11)
                season = "Осень";
            else
                season = "Некорректный месяц.";

            Console.WriteLine(season);
        }
    }
}
