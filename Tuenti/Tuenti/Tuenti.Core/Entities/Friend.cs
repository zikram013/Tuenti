namespace Tuenti.Tuenti.Core.Entities
{
    public class Friend
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FriendUserId { get; set; }
        
        //Navegacion
        public User User { get; set; }
        public User FriendUser { get; set; }
    }
}
