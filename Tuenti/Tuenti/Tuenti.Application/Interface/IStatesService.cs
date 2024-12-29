using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuenti.Tuenti.Core.Entities;

namespace Tuenti.Application.Interface
{
    public interface IStatesService
    {
        Task<IEnumerable<States>> GetAllStatesAsync();
        Task<States> GetStateByIdAsync(int id);
        Task<IEnumerable<States>> GetStatesByUserIdAsync(int userId);
        Task<States> CreateStateAsync(States state);
        Task<States> UpdateStateAsync(States state);
        Task<bool> DeleteStateAsync(int id);
    }
}
