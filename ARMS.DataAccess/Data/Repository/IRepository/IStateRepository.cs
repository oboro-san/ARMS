using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;
using ARMS.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ARMS.DataAccess.Data.Repository.IRepository
{
    public interface IStateRepository : IRepository<State>
    {
        IEnumerable<SelectListItem> GetStateListForDropDown();

        void Update(State state);
    }
}