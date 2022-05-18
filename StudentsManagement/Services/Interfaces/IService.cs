using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsManagement.Services.Interfaces
{
    public interface IService
    {
        public void Add();
        public void Update();
        public void Delete();
        public void GetAll();
    }
}
