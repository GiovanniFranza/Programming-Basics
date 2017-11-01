using System;

public class StartUp
{
    public static void Main()
    {
        var bitcoin = int.Parse(Console.ReadLine());
        var CHY = double.Parse(Console.ReadLine());
        var comision = double.Parse(Console.ReadLine());

        var bitcoinInBGN = bitcoin * 1168;
        var CHYInUSD = CHY * 0.15;
        var USDInBGN = CHYInUSD * 1.76;

        var BGNInEUR = (bitcoinInBGN + USDInBGN) / 1.95;
        var comisionOut = (BGNInEUR * comision) / 100;

        Console.WriteLine(BGNInEUR - comisionOut);
    }
}