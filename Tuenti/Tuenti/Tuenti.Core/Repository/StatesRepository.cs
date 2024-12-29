using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuenti.Core.Repository.Interface;
using Tuenti.Tuenti.Core.Entities;

namespace Tuenti.Core.Repository
{
    public class StatesRepository : Repository<States>, IStatesRepository
    {
        public StatesRepository(DbContext context) : base(context) { }

        public async Task<IEnumerable<States>> GetStatesByUserIdAsync(int userId)
        {
            return await _dbSet
                .Where(s => s.User.Id == userId) // Filtra los estados por el ID del usuario
                .ToListAsync();
        }
    }
}
