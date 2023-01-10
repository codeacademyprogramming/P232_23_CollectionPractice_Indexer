using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();

            DateTime date = DateTime.Now.AddMonths(-2);
            while (date.Date<=DateTime.Now.Date)
            {
                date = date.AddDays(1);

                if (date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday)
                    continue;

                if(date.Day%3==0)
                    emp1.AddAttendance(date.ToString("dd-MM-yyyy"), false);
                else
                    emp1.AddAttendance(date.ToString("dd-MM-yyyy"), true);
            }

            foreach (var item in emp1.WorkDays)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Qayib sayi: "+emp1.GetAbsenceCount());
            Console.WriteLine("Istirak faizi: "+emp1.GetParticipationPercent());
        }
    }
}
