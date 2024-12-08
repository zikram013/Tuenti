namespace Tuenti.Tuenti.Core.Entities;
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string SecondLastName { get; set; }
    public string UserName { get; set; }

    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string? ProfilePictureUrl { get; set; }
    public DateTime DataJoined { get; set; }
    public Boolean Active { get; set; }

    //Navegation
    public ICollection<Post>? Post { get; set; }
    public ICollection<Friend> Friends {get;set;}
}
