using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Blogs
{
   public  interface IBlogService
    {
        public Task<List<Blog>> GetBlogs();
        public Task<Blog> GetBlogById(int id);
        public Task<Blog> Create(Blog blog);
    }
}
