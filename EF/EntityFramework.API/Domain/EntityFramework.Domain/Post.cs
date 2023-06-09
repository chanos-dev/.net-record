﻿namespace EntityFramework.Domain
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }

    public class PostDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Content { get; set; }
        public int BlogId { get; set; }
    }
}