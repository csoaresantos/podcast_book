using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using podcast_book.Infra;
using podcast_book.Repositories;

namespace podcast_book.Controllers
{
    [Route("/api/[controller]")]
    public class BlogController : ControllerBase
    {
        internal AppDatabase Db { get; }

        public BlogController(AppDatabase appDatabase)
        {
            Db = appDatabase;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await Db.Connection.OpenAsync();
            var query = new BlogPostRepository(Db);
            var result = query.LatestPostsAsync();
            return new OkObjectResult(result);
        }
    }
}
