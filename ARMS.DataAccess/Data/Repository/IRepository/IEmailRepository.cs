using System;
using System.Collections.Generic;
using System.Text;
using ARMS.Models;

namespace ARMS.DataAccess.Data.Repository.IRepository
{
    public interface IEmailRepository : IRepository<Email>
    {
        void Update(Email email);
    }
}