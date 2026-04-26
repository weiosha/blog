namespace BlogApp.Models
{
    // This class defines the structure of a blog post.
    public class Post
    {
        // Unique identifier for each post
        public int Id { get; set; }
        
        // Title of the blog post
        public string Title { get; set; }
        
        // Main content of the blog post
        public string Content { get; set; }
        
        // Author of the blog post
        public string Author { get; set; }
    }
}

