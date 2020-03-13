using System;
using System.Collections.Generic;
using System.Text;
using ARMS.Models;

namespace ARMS.DataAccess.Data.Repository.IRepository
{
    public interface IStudentRepository : IRepository<Student>
    {
        void Update(Student student);
    }
}