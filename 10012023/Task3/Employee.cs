using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    internal class Employee
    {
        public string FullName;
        Dictionary<string, bool> _attendances = new Dictionary<string, bool>();

        public void AddAttendance(string date,bool isParticipated)
        {
            if(!_attendances.ContainsKey(date))
                _attendances.Add(date, isParticipated);
        }

        public List<string> WorkDays
        {
            get
            {
                List<string> days = new List<string>();
                foreach (var item in _attendances)
                    days.Add(item.Key);

                return days;
            }
        }
        
        public int GetAbsenceCount()
        {
            int count = 0;

            foreach (var item in _attendances)
            {
                if (!item.Value)
                    count++;
            }

            return count;
        }
        public int GetParticipationPercent()
        {
            var result =  (_attendances.Count - GetAbsenceCount()) *100 / _attendances.Count;
            return result;
        }
    }
}
