using System;

namespace _02.FlowerShop
{
    public class FlowerShop
    {
        public static void Main()
        {
            int magnolias = int.Parse(Console.ReadLine());
            int hyacinths = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactuses = int.Parse(Console.ReadLine());
            double priceGift = double.Parse(Console.ReadLine());

            double priceMagnolias = magnolias * 3.25;
            double priceHyacinths = hyacinths * 4;
            double priceRoses = roses * 3.50;
            double priceCactuses = cactuses * 8;
            double taxes = (priceMagnolias + priceHyacinths + priceRoses + +priceCactuses) * 0.05;

            double total = priceMagnolias + priceHyacinths + priceRoses + +priceCactuses - taxes;

            if (priceGift > total)
            {
                Console.WriteLine("She will have to borrow {0:F0} leva.", Math.Ceiling(priceGift - total));
            }
            else
            {
                Console.WriteLine("She is left with {0:F0} leva.", Math.Floor(total - priceGift));
            }
        }
    }
}
