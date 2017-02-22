using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.BackToThePast
{
    class BackToThePast
    {
        static void Main(string[] args)
        {
            double heritageMoney = double.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());
            double spendMoney = 0;
            int age = 18;

            for (int i = 1800; i <= years; i++)
            {
                if (i % 2 == 0)
                {
                    spendMoney += 12000;
                }
                else
                {
                    spendMoney += 12000 + (50 * age);
                }
                age++;
            }
            if (heritageMoney >= spendMoney)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.", heritageMoney - spendMoney);
            }
            else
            {
                Console.WriteLine("He will need {0:F2} dollars to survive.", spendMoney - heritageMoney);
            }


        }
    }
}
