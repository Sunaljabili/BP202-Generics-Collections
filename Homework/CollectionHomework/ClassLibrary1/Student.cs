using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Student
    {
        public Student()
        {
            _no++;
            No = _no;
        }
        static int _no;
        public int No { get; set; }
        public string FullName { get; set; }
        public Dictionary<string, double> Exams = new Dictionary<string, double>();

        public bool CheckExamsByName(string examname)
        {
            foreach (var item in Exams)
            {
                if (item.Key == examname)
                {
                    return true;
                }
            }
            return false;
        }
        public void AddExam(string examName, double point)
        {
            if (!CheckExamsByName(examName))
            {
                Exams.Add(examName, point);
            }
        }
        public double GetExamResult(string examname)
        {
            foreach (var item in Exams)
            {
                if (item.Key == examname)
                {
                    return item.Value;
                }
            }
            return -1;
        }
        public double GetExamAvg()
        {
            double sum = 0;
            foreach (var item in Exams)
            {
                sum += item.Value;
            }

            return sum / Exams.Count;
        }
        public void GetInfo()
        {
            foreach (var item in Exams)
            {
                Console.WriteLine(item.Key + item.Value);
            }
        }
    }
}
