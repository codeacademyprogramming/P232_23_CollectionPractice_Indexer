using System;
using System.Collections.Generic;

namespace Lesson
{
    internal class Program
    {
        static IEnumerable<string> Weekdays()
        {
            yield return "Bazar ertesi";
            yield return "Cersenbe axsami";
            yield return "Cersenve";
            yield return "Cume axsami";
            yield return "Cume";
            yield return "Senbe";
            yield return "Bazar";
        }
        static void Main(string[] args)
        {
            List<int> numbersList = new List<int>() { 23, -45, 55 };


            MyList<int> numbers = new MyList<int>();
            numbers.Add(1);
            numbers.Add(-45);
            numbers.Add(100);

            numbers[10] = 100;

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
