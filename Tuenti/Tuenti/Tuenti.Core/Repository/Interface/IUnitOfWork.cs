using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuenti.Core.Repository.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        IPostRepository Posts { get; }
        ICommentRepository Comments { get; }
        IFriendRepository Friends { get; }

        IStatesRepository States { get; }

        Task<int> SaveChangesAsync();
    }
}
