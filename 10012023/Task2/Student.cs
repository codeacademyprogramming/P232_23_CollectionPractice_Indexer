using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal class Student
    {
        public string FullName;
        Dictionary<string, int> _exams = new Dictionary<string, int>();
        public List<string>  ExamSubjects { 
            get {
                List<string> list = new List<string>();
                foreach (var item in _exams)
                    list.Add(item.Key);

                return list;
            }
        }
        public void AddExam(string examName,int examPoint)
        {
            //Exams.TryAdd(examName, examPoint);

            if (!_exams.ContainsKey(examName))
                _exams.Add(examName, examPoint);
        }
        public int? GetExamResult(string examName)
        {
            if(_exams.ContainsKey(examName))
                return _exams[examName];
            return null;
        }

        public int GetExamAvg()
        {
            int totalPoint = 0;
            int avgPoint = 0;
            if (_exams.Count > 0)
            {
                foreach (var exam in _exams)
                    totalPoint += exam.Value;

                avgPoint = totalPoint / _exams.Count;
            }

            return avgPoint;
        }
    }
}
