using System;
using System.Collections.Generic;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.FullName = "Abbas Babazade";

            student1.AddExam("Riyaziyyat", 60);
            student1.AddExam("Ana dili", 50);
            student1.AddExam("Fizika", 75);
            student1.AddExam("Fizika", 75);
            student1.AddExam("Tarix", 80);


            foreach (var item in student1.ExamSubjects)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Subject daxil edin:");
            string subject = Console.ReadLine();

            var subjectPoint = student1.GetExamResult(subject);

            if(subjectPoint == null)
                Console.WriteLine("Bele bir subject yoxdur");
            else Console.WriteLine(subjectPoint);


            Console.WriteLine("==========================");
            Console.WriteLine("avg: "+student1.GetExamAvg());
        }
    }
}
