using System;
using System.Collections;
using System.Collections.Generic;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { FullName = "Hikmet Abbasov", GroupNo = "P123" });
            students.Add(new Student { FullName = "Tofiq Abbasov", GroupNo = "P223" });
            students.Add(new Student { FullName = "Nermin Abbasova", GroupNo = "P123" });


            foreach (var item in students)
            {
                Console.WriteLine($"{item.No}-{item.FullName}-{item.GroupNo}");
            }

            Console.WriteLine("Silmek istediyiniz telebe nomresini daxil edin:");
            string noStr = Console.ReadLine();
            int no = Convert.ToInt32(noStr);

            Student student = FindStudentByNo(no,students);

            if(student == null)
                Console.WriteLine("Bele bir telebe yoxdur");
            else
            {
                students.Remove(student);


                foreach (var item in students)
                {
                    Console.WriteLine($"{item.No}-{item.FullName}-{item.GroupNo}");
                }
            }

            Dictionary<string, int> groups = new Dictionary<string, int>();

            groups.Add("P123", 85);
            groups.Add("P124", 75);
            groups.Add("P220", 85);
            groups.Add("P232", 15);

            foreach (var item in groups)
            {
                Console.WriteLine(item.Key);
            }

            Console.WriteLine("GroupNo:");
            string groupNo = Console.ReadLine();


            if (groups.ContainsKey(groupNo))
                Console.WriteLine(groups[groupNo]);
            else
                Console.WriteLine("Bele bir qrup yoxdur");



        }

        static Student FindStudentByNo(int no,List<Student> students)
        {
            foreach (var item in students)
            {
                if (item.No == no)
                    return item;
            }

            return null;
        }
    }
}
