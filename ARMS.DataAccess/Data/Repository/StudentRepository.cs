using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ARMS.DataAccess.Data.Repository.IRepository;
using ARMS.Models;

namespace ARMS.DataAccess.Data.Repository
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        private readonly ApplicationDbContext _db;

        public StudentRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Student student)
        {
            var objFromDb = _db.Students.FirstOrDefault(x => x.StudentId == student.StudentId);

            if (objFromDb != null)
            {
                objFromDb.MatNumber = student.MatNumber;
                objFromDb.RegNumber = student.RegNumber;
                objFromDb.FirstName = student.FirstName;
                objFromDb.MiddleName = student.MiddleName;
                objFromDb.LastName = student.LastName;
                objFromDb.Dob = student.Dob;
                objFromDb.Gender = student.Gender;
                objFromDb.NationalityId = student.NationalityId;
                objFromDb.StateId = student.StateId;
                objFromDb.LgaId = student.LgaId;

                _db.SaveChanges();
            }
        }
    }
}