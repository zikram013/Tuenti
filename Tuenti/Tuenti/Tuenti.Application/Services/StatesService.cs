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
    public class StatesService : IStatesService
    {
        private readonly IUnitOfWork _unitOfWork;

        public StatesService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<States>> GetAllStatesAsync()
        {
            return await _unitOfWork.States.GetAllAsync();
        }

        public async Task<States> GetStateByIdAsync(int id)
        {
            return await _unitOfWork.States.GetByIdAsync(id);
        }

        public async Task<IEnumerable<States>> GetStatesByUserIdAsync(int userId)
        {
            return await _unitOfWork.States.FindAsync(s => s.User.Id == userId);
        }

        public async Task<States> CreateStateAsync(States state)
        {
            await _unitOfWork.States.AddAsync(state);
            await _unitOfWork.SaveChangesAsync();
            return state;
        }

        public async Task<States> UpdateStateAsync(States state)
        {
            _unitOfWork.States.Update(state);
            await _unitOfWork.SaveChangesAsync();
            return state;
        }

        public async Task<bool> DeleteStateAsync(int id)
        {
            var state = await _unitOfWork.States.GetByIdAsync(id);
            if (state == null) return false;

            _unitOfWork.States.Remove(state);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
    }
}
