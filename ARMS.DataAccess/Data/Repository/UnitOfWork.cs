using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ARMS.DataAccess.Data.Repository.IRepository;

namespace ARMS.DataAccess.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Student = new StudentRepository(_db);
            StoredProcCall = new StoredProcCall(_db);
        }

        public IStoredProcCall StoredProcCall { get; private set; }

        public IStudentRepository Student { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}