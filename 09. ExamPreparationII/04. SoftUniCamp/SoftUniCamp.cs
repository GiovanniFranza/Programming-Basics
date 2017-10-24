using System;

namespace _04.SoftUniCamp
{
    public class SoftUniCamp
    {
        public static void Main()
        {
            int numberGroup = int.Parse(Console.ReadLine());
            int totalPeople = 0;
            double people5 = 0;
            double people12 = 0;
            double people25 = 0;
            double people40 = 0;
            double people41 = 0;

            for (int i = 1; i <= numberGroup; i++)
            {
                int peopleInGroup = int.Parse(Console.ReadLine());
                totalPeople += peopleInGroup;
                if (peopleInGroup <= 5)
                {
                    people5 += peopleInGroup;
                }
                else if (peopleInGroup > 5 && peopleInGroup <= 12)
                {
                    people12 += peopleInGroup;
                }
                else if (peopleInGroup > 12 && peopleInGroup <= 25)
                {
                    people25 += peopleInGroup;
                }
                else if (peopleInGroup > 25 && peopleInGroup <= 40)
                {
                    people40 += peopleInGroup;
                }
                else if (peopleInGroup > 40)
                {
                    people41 += peopleInGroup;
                }
            }
            Console.WriteLine("{0:F2}%", (people5 / totalPeople) * 100);
            Console.WriteLine("{0:F2}%", (people12 / totalPeople) * 100);
            Console.WriteLine("{0:F2}%", (people25 / totalPeople) * 100);
            Console.WriteLine("{0:F2}%", (people40 / totalPeople) * 100);
            Console.WriteLine("{0:F2}%", (people41 / totalPeople) * 100);
        }
    }
}
