using System;

namespace _04.Logistics
{
    public class Logistics
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double totalLoad = 0;
            int loadBus = 0;
            int loadTruck = 0;
            int loadTrain = 0;
            
            for (int i = 1; i <= n; i++)
            {
                int load = int.Parse(Console.ReadLine());
                totalLoad += load;
                if (load <= 3)
                {
                    loadBus += load;
                }
                else if (load > 3 && load <= 11)
                {
                    loadTruck += load;
                }
                else if (load > 11)
                {
                    loadTrain += load;
                }
            }
            Console.WriteLine("{0:F2}", (loadBus * 200 + loadTruck * 175 + loadTrain * 120) / totalLoad);
            Console.WriteLine("{0:F2}%", (loadBus / totalLoad) * 100);
            Console.WriteLine("{0:F2}%", (loadTruck / totalLoad) * 100);
            Console.WriteLine("{0:F2}%", (loadTrain / totalLoad) * 100);
        }
    }
}
