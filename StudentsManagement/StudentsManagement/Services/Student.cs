using System;
using System.Collections.Generic;
using System.Text;
using StudentsManagement.Services.Interfaces;

namespace StudentsManagement.Services
{
    public class Student
    {
        public static List<Entities.Student> Students = new List<Entities.Student>();

        public static void GetAll()
        {
            foreach (var item in Students)
            {
                item.Display();
            }
        }
        public static void Add()
        {
            Entities.Student student = new Entities.Student();
            Console.Write("Codigo del estudiante: ");
            student.StudentCode = Console.ReadLine();
            Console.Write("Nombre del estudiante: ");
            student.Name = Console.ReadLine();
            Console.Write("Apellido del estudiante: ");
            student.Lastname = Console.ReadLine();
            Students.Add(student);
        }
        public static void AddSubject(string studentcode, string subjectCode)
        {
            var student = new Entities.Student();
            var subject = new Entities.Subject();
            int studentIndex = new int();

            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].StudentCode == studentcode)
                {
                    student = Students[i];
                    studentIndex = i;
                    break;
                }
            }

            foreach (var item in Subject.Subjects)
            {
                if (item.SubjectCode == subjectCode)
                {
                    subject = item;
                    break;
                }
            }

            student.Subjects.Add(subject);
            Students[studentIndex] = student;
        }
        public static void Delete()
        {
            throw new NotImplementedException();
        }
        public static void Update()
        {
            throw new NotImplementedException();
        }
    }
}
