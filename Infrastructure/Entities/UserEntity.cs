using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class UserEntity : IdentityUser
{
    [Key]
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? ProfileImage { get; set; } = "avatar.jpg";
    public string? Bio { get; set; }
    public int? AddressId { get; set; }
    public AddressEntity? Address { get; set; }

}
