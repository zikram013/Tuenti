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
    public class PostRepository : Repository<Post>, IPostRepository
    {
        public PostRepository(DbContext context) : base(context) { }

        public async Task<IEnumerable<Post>> GetPostWithCommentsAsync()
        {
            return await _dbSet.Include(p => p.Comments).ToListAsync();
        }
    }
}
