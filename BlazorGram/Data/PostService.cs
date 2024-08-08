using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazorGram.Data
{
    public class PostService
    {
        private readonly AppDbContext _appDbContext;

        public PostService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Post>> GetPosts()
        {
            return await _appDbContext.Posts.ToListAsync();
        }

        public async Task<Post> GetPost(int postId)
        {
            Post post = await _appDbContext.Posts.FirstOrDefaultAsync(p => p.Id.Equals(postId));
            return post;
        }

        public async Task InsertPost(Post post)
        {
            await _appDbContext.Posts.AddAsync(post);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task UpdatePost(Post post)
        {
            _appDbContext.Posts.Update(post);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task DeletePost(Post post)
        {
            _appDbContext.Posts.Remove(post);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
