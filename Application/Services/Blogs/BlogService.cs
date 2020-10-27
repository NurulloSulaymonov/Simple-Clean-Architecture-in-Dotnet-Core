using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Blogs
{
    public class BlogService : IBlogService
    {
        private readonly DataContext _context;

        public BlogService(DataContext context)
        {
            _context = context;
        }
        public Task<Blog> Create(Blog blog)
        {
            throw new NotImplementedException();
        }

        public async Task<Blog> GetBlogById(int id)
        {
            var blog = await  _context.Blogs.FindAsync(id);
            return blog;
        }

        public async Task<List<Blog>> GetBlogs()
        {
            var blogs = await _context.Blogs.ToListAsync();
            return blogs;
        }
    }
}
