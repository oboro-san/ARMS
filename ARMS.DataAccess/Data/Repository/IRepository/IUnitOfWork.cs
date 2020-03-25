using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ARMS.DataAccess.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentRepository Student { get; }

        IStateRepository State { get; }

        void Save();

        Task SaveAsync();
    }
}