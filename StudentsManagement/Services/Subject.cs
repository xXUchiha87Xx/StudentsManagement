using StudentsManagement.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsManagement.Services
{
    public class Subject
    {
        public static List<Entities.Subject> Subjects = new List<Entities.Subject>();

        public static void Add()
        {
            Entities.Subject subject = new Entities.Subject();
            Console.Write("Codigo de la materia: ");
            subject.SubjectCode = Console.ReadLine();
            Console.Write("Nombre de la materia: ");
            subject.Name = Console.ReadLine();
            Subjects.Add(subject);
        }

        public static void Delete()
        {
            throw new NotImplementedException();
        }

        public static void GetAll()
        {

        }

        public static void Update()
        {
            throw new NotImplementedException();
        }
    }
}
