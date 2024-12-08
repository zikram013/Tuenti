namespace Tuenti.Tuenti.Core.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
        public DateTime DatePosted { get; set; }

        //Navegacion
        public Post Post { get; set; }
        public User User { get; set; }
    }
}
