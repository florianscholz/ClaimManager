using System.Collections.Generic;
using System.Linq;
using ClaimManager.DataLayer.DbContext;
using ClaimManager.DataLayer.Models;

namespace ClaimManager.DataLayer.Repositories
{
    public class LossTypeRepository : ILossTypeRepository
    {
        private DatabaseContext _databaseContext;

        public LossTypeRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public List<LossType> GetLossTypes()
        {
            return _databaseContext.LossTypes.AsQueryable().ToList();
        }
    }
}