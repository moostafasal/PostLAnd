namespace PostLAndDomin
{
    public class Category
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }

        // Navigation property for Posts
        public ICollection<Post> Posts { get; set; }
    }

}
