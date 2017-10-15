using System;

namespace _14.OnTimeExam
{
    public class OnTimeExam
    {
        public static void Main()
        {
            var hourExam = int.Parse(Console.ReadLine());
            var minuteExam = int.Parse(Console.ReadLine());
            var hourArrive = int.Parse(Console.ReadLine());
            var minuteArrive = int.Parse(Console.ReadLine());

            var timeExam = (hourExam * 60) + minuteExam;
            var timeArrive = (hourArrive * 60) + minuteArrive;

            if (timeArrive == timeExam)
            {
                Console.WriteLine("On time");
            }
            else if (timeExam < timeArrive)
            {
                Console.WriteLine("Late");
                if (timeArrive - timeExam < 60)
                {
                    Console.WriteLine("{0} minutes after the start", timeArrive - timeExam);
                }
                else
                {
                    if ((timeArrive - timeExam) % 60 < 10)
                    {
                        Console.WriteLine("{0}:0{1} hours after the start", (timeArrive - timeExam) / 60, (timeArrive - timeExam) % 60);
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1} hours after the start", (timeArrive - timeExam) / 60, (timeArrive - timeExam) % 60);
                    }

                }
            }
            else if (0 < timeExam - timeArrive && timeExam - timeArrive <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start", timeExam - timeArrive);

            }
            else if (timeExam - timeArrive > 30)
            {
                Console.WriteLine("Early");
                if (timeArrive - timeExam > 30 && timeArrive - timeExam < 60)
                {
                    Console.WriteLine("{0} minutes before the start", timeArrive - timeExam);
                }
                else
                {
                    if ((timeArrive - timeExam) % 60 < 60)
                    {
                        Console.WriteLine("{0} minutes before the start", (timeExam - timeArrive) % 60);
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1} hours before the start", (timeExam - timeArrive) / 60, (timeExam - timeArrive) % 60);
                    }
                }
            }
        }
    }
}
