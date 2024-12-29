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
    public class CommentService : ICommentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CommentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Comment>> GetAllCommentsAsync()
        {
            return await _unitOfWork.Comments.GetAllAsync();
        }

        public async Task<Comment> CreateCommentAsync(Comment comment)
        {
            await _unitOfWork.Comments.AddAsync(comment);
            await _unitOfWork.SaveChangesAsync();
            return comment;
        }
    }
}
