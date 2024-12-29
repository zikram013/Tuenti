using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuenti.Tuenti.Core.Entities;

namespace Tuenti.Application.Interface
{
    public interface IFriendService
    {
        Task<IEnumerable<Friend>> GetAllFriendsAsync();
        Task<IEnumerable<Friend>> GetFriendsByUserIdAsync(int userId);
        Task<Friend> AddFriendAsync(Friend friend);
    }
}
