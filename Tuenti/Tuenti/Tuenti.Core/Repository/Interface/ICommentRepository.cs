using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuenti.Tuenti.Core.Entities;

namespace Tuenti.Core.Repository.Interface
{
    public interface ICommentRepository : IRepository<Comment>
    {
        Task<IEnumerable<Comment>> GetCommentsByPostdAsync(int id);
    }
}
