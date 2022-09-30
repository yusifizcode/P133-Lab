using _30._09._2022.Models;
using System;
using System.Collections.Generic;

namespace _30._09._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            bool check = true;
            do
            {
                Console.WriteLine("1. Telebe elave et");
                Console.WriteLine("2. Telebeye imtahan elave et");
                Console.WriteLine("3. Telebenin bir imtahan balina bax");
                Console.WriteLine("4. Telebenin butun imtahanlarini goster");
                Console.WriteLine("5. Telebenin imtahan ortalamasini goster");
                Console.WriteLine("6. Telebeden imtahan sil");
                Console.WriteLine("0. Proqrami bitir");

                string answerStr = Console.ReadLine();
                int answerInt;

                while (!int.TryParse(answerStr,out answerInt) || answerInt < 0 || answerInt > 6)
                {
                    Console.WriteLine("Duzgun sechim edin! ");
                    answerStr = Console.ReadLine();
                }

                switch (answerInt)
                {
                    case 1:
                        Console.WriteLine("Telebenin adini daxil et: ");
                        string fullName = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(fullName)) {
                            Student student = new Student();
                            students.Add(student);
                        }
                        break;

                        case 2:
                        Console.WriteLine("Telebenin nomresini daxil edin: ");
                        string studentNo = Console.ReadLine();
                        int studentNoInt;
                        while(!int.TryParse(studentNo, out studentNoInt))
                        {
                            Console.WriteLine("Duzgun nomre daxil edin: ");
                            studentNo = Console.ReadLine();
                        }
                        Console.WriteLine("Imtahanin adini daxil edin: ");
                        string examName = Console.ReadLine();
                        while (string.IsNullOrWhiteSpace(examName))
                        {
                            examName = Console.ReadLine();
                        }


                        Console.WriteLine("Imtahan balini daxil edin: ");
                        string pointStr = Console.ReadLine();
                        int pointInt;

                        while (!int.TryParse(pointStr,out pointInt))
                        {
                            pointStr = Console.ReadLine();
                        }

                        foreach (Student student in students)
                        {
                            if(studentNoInt == student.No)
                            {
                                student.AddExam(examName, pointInt);
                            }
                        }

                        break;

                    case 3:
                        Console.WriteLine("Telebenin nomresini daxil edin: ");
                        studentNo = Console.ReadLine();
                        
                        while (!int.TryParse(studentNo, out studentNoInt))
                        {
                            Console.WriteLine("Duzgun nomre daxil edin: ");
                            studentNo = Console.ReadLine();
                        }
                        Console.WriteLine("Imtahanin adini daxil edin: ");
                        examName = Console.ReadLine();
                        while (string.IsNullOrWhiteSpace(examName))
                        {
                            examName = Console.ReadLine();
                        }

                        foreach (Student student in students)
                        {
                            if(studentNoInt == student.No)
                            {
                                Console.WriteLine(student.GetExamResult(examName));
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Telebenin nomresini daxil edin: ");
                        studentNo = Console.ReadLine();

                        while (!int.TryParse(studentNo, out studentNoInt))
                        {
                            Console.WriteLine("Duzgun nomre daxil edin: ");
                            studentNo = Console.ReadLine();
                        }

                        foreach (Student student in students)
                        {
                            if(studentNoInt == student.No)
                            {
                                foreach (string exam in student.Exams.Keys)
                                {
                                    Console.WriteLine(exam);
                                }
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("Telebenin nomresini daxil edin: ");
                        studentNo = Console.ReadLine();

                        while (!int.TryParse(studentNo, out studentNoInt))
                        {
                            Console.WriteLine("Duzgun nomre daxil edin: ");
                            studentNo = Console.ReadLine();
                        }

                        foreach (Student student in students)
                        {
                            if(studentNoInt == student.No)
                            {
                                Console.WriteLine(student.GetExamAvg());
                            }
                        }
                        break;

                    case 6:
                        Console.WriteLine("Telebenin nomresini daxil edin: ");
                        studentNo = Console.ReadLine();

                        while (!int.TryParse(studentNo, out studentNoInt))
                        {
                            Console.WriteLine("Duzgun nomre daxil edin: ");
                            studentNo = Console.ReadLine();
                        }
                        Console.WriteLine("Imtahanin adini daxil edin: ");
                        examName = Console.ReadLine();
                        while (string.IsNullOrWhiteSpace(examName))
                        {
                            examName = Console.ReadLine();
                        }

                        foreach (Student student in students)
                        {
                            if(studentNoInt == student.No)
                            {
                                student.Exams.Remove(examName);
                            }
                        }
                        break;


                    default:
                        check = false;
                        break;
                }

            } while (check);

        }
    }
}
