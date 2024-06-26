namespace PostLAndDomin
{
    public class Post
    {
        public Guid PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }

}
