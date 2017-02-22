using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Hospital
{
    class Hospital
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int doctors = 7;
            int viewPatient = 0;
            int unviewPatient = 0;

            for (int i = 1; i <= period; i++)
            {
                int patients = int.Parse(Console.ReadLine());
                if ((i % 3 == 0) && (unviewPatient > viewPatient))
                {
                    doctors++;
                }
                if (patients > doctors)
                {
                    viewPatient += doctors;
                    unviewPatient += patients - doctors;
                }
                else
                {
                    viewPatient += patients;
                }

            }
            Console.WriteLine("Treated patients: {0}.", viewPatient);
            Console.WriteLine("Untreated patients: {0}.", unviewPatient);
        }
    }
}
