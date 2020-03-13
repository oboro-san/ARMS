using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ARMS.DataAccess.Data.Repository.IRepository;
using ARMS.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ARMS.DataAccess.Data.Repository
{
    public class StateRepository : Repository<State>, IStateRepository
    {
        private readonly ApplicationDbContext _db;

        public StateRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetStateListForDropDown()
        {
            return _db.States.Select(x => new SelectListItem()
            {
                Text = x.NameOfState,
                Value = x.Id.ToString()
            });
        }

        public void Update(State state)
        {
            var objFromDb = _db.States.FirstOrDefault(x => x.Id == state.Id);

            if (objFromDb != null)
            {
                objFromDb.NameOfState = state.NameOfState;

                _db.SaveChanges();
            }
        }
    }
}