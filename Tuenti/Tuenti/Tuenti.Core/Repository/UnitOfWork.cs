using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuenti.Core.Repository.Interface;

namespace Tuenti.Core.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;

        public IUserRepository Users { get; private set; }
        public IPostRepository Posts { get; private set; }
        public ICommentRepository Comments { get; private set; }
        public IFriendRepository Friends { get; private set; }

        public IStatesRepository States { get; private set; }

        public UnitOfWork(DbContext context)
        {
            _context = context;
            Users = new UserRepository(context);
            Posts = new PostRepository(context);
            Comments = new CommentRepository(context);
            Friends = new FriendRepository(context);
            States = new StatesRepository(context);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
