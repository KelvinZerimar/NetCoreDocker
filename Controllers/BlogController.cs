using mydockerapi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace mydockerapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController: ControllerBase
    {
        private readonly ApiDbContent _context;

        public BlogController(ApiDbContent context)
        {
            _context = context;
        }

        /// <summary>
        /// This method shows all blogs
        /// </summary>
        /// <returns></returns>
        ///<remarks>
        /// Sample request
        /// GET/Blog
        /// </remarks> 
        [HttpGet]
        public object Get()
        {
            return _context.Blogs.Where(b=>b.Title.Contains("Title")).Select((c)=> new 
            {
                Id = c.Id,
                Title = c.Title,
                Description = c.Description
            }).ToList();
        }

        /// <summary>
        /// This method shows all blogs by title
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        ///<remarks>
        /// Sample request
        /// GET/Blog/title1
        /// </remarks>
        [HttpGet("{title}")]
        public object GetByTitle(string title)
        {
            return _context.Blogs.Where(b => b.Title == title).Select((c) => new
            {
                Id = c.Id,
                Title = c.Title,
                Description = c.Description
            }).ToList();
        }
    }
}
