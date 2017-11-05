using System;

public class StartUp
{
    public static void Main()
    {
        double priceMackerel = double.Parse(Console.ReadLine());
        double priceSprat = double.Parse(Console.ReadLine());
        double weightBelted = double.Parse(Console.ReadLine());
        double weightScad = double.Parse(Console.ReadLine());
        int weightShell = int.Parse(Console.ReadLine());

        double priceBelted = priceMackerel + priceMackerel * 0.60;
        double totalBelted = weightBelted * priceBelted;
        double priceScad = priceSprat + priceSprat * 0.80;
        double totalScad = weightScad * priceScad;
        double totalShell = weightShell * 7.50;
        double total = totalBelted + totalScad + totalShell;
        Console.WriteLine("{0:F2}", total);
    }
}