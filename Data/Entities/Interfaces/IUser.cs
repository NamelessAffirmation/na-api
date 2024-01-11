namespace Data.Entities.Interfaces;

public interface IUser
{
    int Id { get; set; }
    DateTime Created { get; set; }
    DateTime Modified { get; set; }
    DateTime Deleted { get; set; }
    string Email { get; set; }
    string PasswordHash { get; set; }
    bool IsVerified { get; set; }
    string ApiKey { get; set; }
}