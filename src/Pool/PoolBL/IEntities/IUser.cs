using System.ComponentModel.DataAnnotations;
using CMN;

namespace PoolBL;
public interface IUser : IEntity
{
    string FirstName { get; set; }
    string LastName { get; set; }
    byte? Age { get; set; }
    string? Email { get; set; }
    string? UserName { get; set; }
    string? Password { get; set; }
    string? PhoneNumber { get; set; }
}
