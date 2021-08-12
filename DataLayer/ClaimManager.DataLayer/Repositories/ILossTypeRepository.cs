using System.Collections.Generic;
using ClaimManager.DataLayer.Models;

namespace ClaimManager.DataLayer.Repositories
{
    public interface ILossTypeRepository
    {
        public List<LossType> GetLossTypes();
    }
}