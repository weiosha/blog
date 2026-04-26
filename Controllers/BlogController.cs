using Microsoft.AspNetCore.Mvc;
using BlogApp.Models;
using System.Collections.Generic;

namespace BlogApp.Controllers
{
    public class BlogController : Controller
    {
        // Temporary in-memory list of posts
        private static List<Post> posts = new List<Post>
        {
            new Post { Id = 1, Title = "First Post", Content = "This is the first blog post.", Author = "Juan" },
            new Post { Id = 2, Title = "Second Post", Content = "This is the second blog post.", Author = "Maria" }
        };

        // GET: /Blog/
        public IActionResult Index()
        {
            // Returns the list of posts to the view
            return View(posts);
        }

        // GET: /Blog/Details/{id}
        public IActionResult Details(int id)
        {
            // Find the post by Id
            var post = posts.Find(p => p.Id == id);

            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }
    }
}


