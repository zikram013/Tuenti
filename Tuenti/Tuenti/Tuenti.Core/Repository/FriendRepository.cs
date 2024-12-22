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
    public class FriendRepository : Repository<Friend>, IFriendRepository
    {
        public FriendRepository(DbContext context) : base(context) { }

        public async Task<IEnumerable<Friend>> GetFriendsByUserIdAsync(int userId)
        {
            return await _dbSet
                .Where(f => f.UserId == userId)
                .ToListAsync();
        }
    }
}
