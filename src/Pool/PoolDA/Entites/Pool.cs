using PoolBL;
using PoolDA.Entites;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PoolDA;

[Table("Pool", Schema = "Pool")]
public class Pool :BaseEntity , IPool
{
    #region Realation
    public ICollection<Employee>? Employees { get; set; }
    public ICollection<Ticket>? Tickets { get; set; }
    public ICollection<Reserved>? Reserveds { get; set; }
    public ICollection<Sans>? Sans { get; set; }

    #endregion
    #region Properties
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    [Required]
    [MaxLength(500)]
    public string Address { get; set; }

    [MaxLength(13)]
    public string? PhoneNumber { get; set; }
    #endregion


}

