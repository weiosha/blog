namespace BlogApp.Models
{
    // This class defines the structure of a blog post.
    public class Post
    {
        // Unique identifier for each post
        private int id;
        public int Id { 
            get {return id; } 
            set {id = value; } 
        }
        
        // Title of the blog post
        public string title = "";
        public string Title { 
            get {return title; } 
            set {title = value; } 
        }
        
        // Main content of the blog post
        private string content = "";
        public string Content {
            get {return content; } 
            set {content = value; } 
        }
        
        // Author of the blog post
        private string author = "";
        public string Author{
            get {return author; } 
            set {author = value; } 
        }
    }
}

