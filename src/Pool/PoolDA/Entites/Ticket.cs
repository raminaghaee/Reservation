using Microsoft.EntityFrameworkCore;
using PoolBL;
using PoolDA.Entites;
using System.ComponentModel.DataAnnotations.Schema;

namespace PoolDA;

[Table("Ticket", Schema = "Pool")]
public class Ticket : BaseEntity , ITicket
{
    #region Realation
    public int PoolId { get; set; }
    public Pool Pool { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public ICollection<Reserved>? Reserveds { get; set; }
    public Pay Pay { get; set; }
    public int? EmployeeId { get; set; }
    public Employee? Employee { get; set; }
    #endregion

    #region Properity
    /// <summary>
    /// New, Regolar, VIP
    /// </summary>
    public int TicketTypeId { get; set; }
    /// <summary>
    /// Internet , Operator , Stand
    /// </summary>
    public int CreateTypeId { get; set; }

    public decimal Price { get; set; }
    #endregion

}

