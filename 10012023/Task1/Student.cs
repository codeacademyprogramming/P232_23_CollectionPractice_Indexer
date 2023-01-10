using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    internal class Student
    {
        private static int _counter = 100;

        public Student()
        {
            _counter++;
            No = _counter;
        }

        public int No;
        public string FullName;
        public string GroupNo;
    }
}
