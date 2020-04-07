using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ARMS.DataAccess.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IStoredProcCall StoredProcCall { get; }

        IStudentRepository Student { get; }

        void Save();

        Task SaveAsync();
    }
}