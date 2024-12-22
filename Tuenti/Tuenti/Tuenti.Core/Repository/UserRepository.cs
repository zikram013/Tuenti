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
    public class UserRepository:Repository<User>,IUserRepository
    {
        public UserRepository(DbContext dbContext):base(dbContext) { }

        public async Task<User> GetUserWithFriendsAsync(int id) 
        {
            return await _dbSet.Include(x => x.Friends).FirstOrDefaultAsync(u => u.Id == id);
        }
    }
}
