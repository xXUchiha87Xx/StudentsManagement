using StudentsManagement.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsManagement.Services
{
    public class Subject
    {
        public static List<Entities.Subject> Subjects = new List<Entities.Subject>();

        public void Add()
        {
            Entities.Subject subject = new Entities.Subject();

        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
