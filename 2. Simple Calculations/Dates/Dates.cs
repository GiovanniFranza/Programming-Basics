using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates
{
    class Dates
    {
        static void Main(string[] args)
        {

            var date = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var date2 = date.AddDays(999);
            Console.WriteLine("{0}", date2.ToString("dd-MM-yyyy"));



            //string input = DateTime.ParseExact("dd-MM-yyyy");
            //DateTime date = DateTime.ParseExact(input, "dd-MM-yyyy", null);
            //DateTime date2 = date.AddDays(999);

            //Console.WriteLine("{0}", date2.ToString("dd-MM-yyyy"));

            //DateTime date = new DateTime(2016, 10, 13, 15, 31, 5);
            //Console.WriteLine(date.ToString());
            //Console.WriteLine(date.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("fr-FR")));
            //Console.WriteLine(date.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("bg-BG")));
            //Console.WriteLine(date.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("us-US")));

            //DateTime today = DateTime.Now;
            //DateTime tomorow = today.AddDays(10);
            //Console.WriteLine("Today is: " + today);
            //Console.WriteLine("After 10 days is: " + tomorow);
            //DateTime date = new DateTime(2016, 10, 13, 15, 44, 20);
            //Console.WriteLine(date.ToString());
        }
    }
}
