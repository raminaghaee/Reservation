using PoolBL;
using PoolDA.Entites;
using System.ComponentModel.DataAnnotations.Schema;

namespace PoolDA;

[Table("Employee", Schema = "Pool")]
public class Employee : BaseEntity , IEmployee
{
    #region Realation
    public int PoolId { get; set; }

    public Pool Pool { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }

    public ICollection<Ticket>? Tickets { get; set; }
    public ICollection<Reserved>? Reserveds { get; set; }
    #endregion
    public decimal Salary { get; set; }
}

