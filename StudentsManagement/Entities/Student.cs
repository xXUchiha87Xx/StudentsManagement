using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsManagement.Entities
{
    public class Student
    {
        public string StudentCode { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public List<Subject> Subjects { get; set; }
        public void Display()
        {
            Console.WriteLine("========================");
            Console.WriteLine("Codigo del estudiante: {0}", StudentCode);
            Console.WriteLine("Nombre del estudiante: {0}", Name);
            Console.WriteLine("Apellido del estudiante: {0}", Lastname);
            Console.WriteLine("========================");
        }
    }
}
