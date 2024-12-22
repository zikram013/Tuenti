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
    public class CommentRepository : Repository<Comment>,ICommentRepository
    {
        public CommentRepository(DbContext dbContext):base(dbContext) { }

        public async Task<IEnumerable<Comment>> GetCommentsByPostdAsync(int id) 
        { 
            return await _dbSet.Where(c=>c.PostId == id).ToListAsync();
        }
    }
}
