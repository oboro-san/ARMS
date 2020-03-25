using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using ARMS.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ARMS.DataAccess.Data.Repository.IRepository
{
    public interface IStateRepository : IRepository<State>
    {
        IEnumerable<SelectListItem> GetStateListForDropDown();

        void Update(State state);

        Task UpdateAsync(State state);
    }
}