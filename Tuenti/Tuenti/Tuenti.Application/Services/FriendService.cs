using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuenti.Application.Interface;
using Tuenti.Core.Repository.Interface;
using Tuenti.Tuenti.Core.Entities;

namespace Tuenti.Application.Services
{
    public class FriendService : IFriendService
    {
        private readonly IUnitOfWork _unitOfWork;

        public FriendService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Friend>> GetAllFriendsAsync()
        {
            return await _unitOfWork.Friends.GetAllAsync();
        }

        public async Task<IEnumerable<Friend>> GetFriendsByUserIdAsync(int userId)
        {
            return await _unitOfWork.Friends.GetFriendsByUserIdAsync(userId);
        }

        public async Task<Friend> AddFriendAsync(Friend friend)
        {
            await _unitOfWork.Friends.AddAsync(friend);
            await _unitOfWork.SaveChangesAsync();
            return friend;
        }
    }
}
