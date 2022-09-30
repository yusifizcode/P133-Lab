using System;
using System.Collections.Generic;
using System.Text;

namespace _30._09._2022.Models
{
    internal class Student
    {
        static Student()
        {
            _no = 0;
        }
        public Student()
        {
            _no++;
            No = _no;
        }

        static int _no;
        public int No;
        public string FullName { get; set; }
        public Dictionary<string, int> Exams { get; set; } = new Dictionary<string, int>();

        public void AddExam(string examName,int point)
        {
            if (!Exams.ContainsKey(examName))
            {
                Exams.Add(examName, point);
            }
            else
            {
                Console.WriteLine("Bele bir imtahan var!");
            }
        }

        public int GetExamResult(string examName)
        {
            foreach (string key in Exams.Keys)
            {
                if(key == examName)
                {
                    return Exams[key];
                }
            }
            return -1;
        }

        public double GetExamAvg()
        {
            int sum = 0;
            foreach (int point in Exams.Values)
            {
                sum += point;
            }

            return sum / Exams.Count;
        }
    }
}
