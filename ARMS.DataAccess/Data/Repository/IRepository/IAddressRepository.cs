using System;
using System.Collections.Generic;
using System.Text;
using ARMS.Models;

namespace ARMS.DataAccess.Data.Repository.IRepository
{
    public interface IAddressRepository : IRepository<Address>
    {
        void Update(Address address);
    }
}