namespace Tuenti.Tuenti.Core.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }

        public DateTime DatePosted { get; set; }

        //Navegacion
        public User User { get; set; }
        public ICollection<Comment>? Comments { get; set;}
    }
}
