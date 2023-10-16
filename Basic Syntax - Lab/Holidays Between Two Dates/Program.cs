using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holidays_Between_Two_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Грешка 1: Форматът  "dd" трябва да се коригира на "d", защото иначе, когато въведеш едноцифрено число ти добавя 0 пред него.
            // Грешка 2: Форматът за месеците трябва да е  "М", а не с малка буква (което е минути).
            // Грешка 3: Във for цикъла трябва да се запази променената дата -> date = date.AddDays(1), иначе не запаметява промяната.
            // Грешка 4: Операторът &&  трябва да се замести с ||

            var startDate = DateTime.ParseExact(Console.ReadLine(),"d.M.yyyy", CultureInfo.InvariantCulture);

            var endDate = DateTime.ParseExact(Console.ReadLine(),"d.M.yyyy", CultureInfo.InvariantCulture);

            var holidaysCount = 0;

            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                }
            }

            Console.WriteLine(holidaysCount);
        }
    }
}
