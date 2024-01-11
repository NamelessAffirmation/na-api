using Data.Entities.Interfaces;

namespace Data.Entities.Impl;

public class User : IUser
{
    public int Id { get; set; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
    public DateTime Deleted { get; set; }
    public string Email { get; set; } = String.Empty;
    public string PasswordHash { get; set; } = String.Empty;
    public bool IsVerified { get; set; }
    public string ApiKey { get; set; } = String.Empty;
}