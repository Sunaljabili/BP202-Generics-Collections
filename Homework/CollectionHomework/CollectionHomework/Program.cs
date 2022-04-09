using System;
using System.Collections.Generic;
using Models;

namespace CollectionHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> Students = new List<Student>();
            string answer = "";
            do
            {
                Console.WriteLine("==========M E N U===========");
                Console.WriteLine("1. Telebe elave et.");
                Console.WriteLine("2. Telebeye imtahan elave et.");
                Console.WriteLine("3. Telebenin 1 imtahan balina bax.");
                Console.WriteLine("4. Telebenin butun imtahan ballarini goster.");
                Console.WriteLine("5. Telebenin imtahan ortalamasin goster.");
                Console.WriteLine("6. Telebeden imtahani sil.");
                Console.WriteLine("0. Proqrami bitir\n\n");
                Console.WriteLine("Secim edin: ");
                answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        Console.WriteLine("Telebenin fullnami daxil edin: ");
                        string fullname = Console.ReadLine();
                        Student student = new Student();
                        student.FullName = fullname;
                        Students.Add(student);
                        break;
                    case "2":
                        Console.WriteLine("No daxil edin: ");
                        int no = int.Parse(Console.ReadLine());
                        foreach (var item in Students)
                        {
                            if (item.No == no)
                            {
                                Console.WriteLine("ExamName daxil edin: ");
                                string examname = Console.ReadLine();
                                Console.WriteLine("Point daxil edin: ");
                                double point = double.Parse(Console.ReadLine());
                                item.AddExam(examname, point);
                            }
                        }
                        break;
                    case "3":
                        Console.WriteLine("No daxil edin: ");
                        int examresult = int.Parse(Console.ReadLine());
                        Console.WriteLine("ExamName daxil edin: ");
                        string examnameresult = Console.ReadLine();
                        foreach (var item in Students)
                        {
                            if (item.No == examresult)
                            {
                                Console.WriteLine(item.GetExamResult(examnameresult)); 
                            }
                        }
                        break;
                    case "4":
                        Console.WriteLine("No daxil edin: ");
                        int allexamresult = int.Parse(Console.ReadLine());
                        foreach (var item in Students)
                        {
                            if (item.No == allexamresult)
                            {
                                item.GetInfo();
                            }
                        }
                        break;
                    case "5":
                        Console.WriteLine("No daxil edin: ");
                        int avgexamresult = int.Parse(Console.ReadLine());
                        foreach (var item in Students)
                        {
                            if (item.No == avgexamresult)
                            {
                                Console.WriteLine(item.GetExamAvg());
                            }
                        }
                        break;
                    case "6":
                        Console.WriteLine("No daxil edin: ");
                        int removeexamresult = int.Parse(Console.ReadLine());
                        Console.WriteLine("ExamName daxil edin: ");
                        string removeexamname = Console.ReadLine();
                        foreach (var item in Students)
                        {
                            if (item.No == removeexamresult )
                            {
                                item.Exams.Remove(removeexamname);
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Verilimis menyudan secim edin: ");
                        break;
                }
            } while (answer!="0");
        }
    }
}
