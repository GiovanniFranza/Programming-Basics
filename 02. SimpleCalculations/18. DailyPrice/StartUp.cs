using System;

public class StartUp
{
    public static void Main()
    {
        var workDayInMonth = int.Parse(Console.ReadLine());
        var moneyPerDay = double.Parse(Console.ReadLine());
        var USDCourseBGN = double.Parse(Console.ReadLine());

        var monthSalary = workDayInMonth * moneyPerDay;
        var yearMoney = (monthSalary * 12) + (monthSalary * 2.5);
        var taxes = (yearMoney * 25) / 100;
        var yearMoneyWithTaxes = (yearMoney - taxes) * USDCourseBGN;
        var moneyPerDayWithTaxes = yearMoneyWithTaxes / 365;

        Console.WriteLine("{0:F2}", moneyPerDayWithTaxes);
    }
}