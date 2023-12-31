using System.ComponentModel.DataAnnotations;
namespace PoolBL;

public partial class User : BaseEntity
{
   
    #region Relations
    public ICollection<Employee> Employees { get; set; }
    public ICollection<Ticket> Tickets { get; set; }
    public ICollection<Reserved> Reserveds { get; set; }
    #endregion
    #region Properties
    [MaxLength(20)]
    public string FirstName { get; set; }
    [MaxLength(20)]
    public string LastName { get; set; }
    public byte? Age { get; set; }
    [MaxLength(200)]
    public string? Email { get; set; }
    [MaxLength(50)]
    public string? UserName { get; set; }
    [MaxLength(50)]
    public string? Password { get; set; }
    [MaxLength(13)]
    public string? PhoneNumber { get; set; }
    #endregion

}

