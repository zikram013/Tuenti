﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuenti.Tuenti.Core.Entities;

namespace Tuenti.Core.Repository.Interface
{
    public interface IStatesRepository : IRepository<States>
    {
        Task<IEnumerable<States>> GetStatesByUserIdAsync(int userId);
    }
}
