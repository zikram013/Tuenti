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
    public class PostService : IPostService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PostService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Post>> GetAllPostsAsync()
        {
            return await _unitOfWork.Posts.GetAllAsync();
        }

        public async Task<Post> GetPostByIdAsync(int id)
        {
            return await _unitOfWork.Posts.GetByIdAsync(id);
        }

        public async Task<Post> CreatePostAsync(Post post)
        {
            await _unitOfWork.Posts.AddAsync(post);
            await _unitOfWork.SaveChangesAsync();
            return post;
        }

        public async Task<Post> UpdatePostAsync(Post post)
        {
            _unitOfWork.Posts.Update(post);
            await _unitOfWork.SaveChangesAsync();
            return post;
        }

        public async Task<bool> DeletePostAsync(int id)
        {
            var post = await _unitOfWork.Posts.GetByIdAsync(id);
            if (post == null) return false;

            _unitOfWork.Posts.Remove(post);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
    }
}
