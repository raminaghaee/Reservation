using System.ComponentModel.DataAnnotations.Schema;
using static CMN.Enums;

namespace PoolBL;

[Table("Ticket", Schema = "Pool")]
public class Ticket : BaseEntity
{
    #region Realation
    public int PoolId { get; set; }
    public Pool Pool { get; set; }
    public int? UserId { get; set; }
    public User? User { get; set; }
    public ICollection<Reserved>? Reserveds { get; set; }
    public Pay Pay { get; set; }
    public int? EmployeeId { get; set; }
    public Employee? Employee { get; set; }
    #endregion

    #region Properity

    /// <summary>
    /// Regolar = 15,
    /// VIP = 16 , 
    /// New = 17, 
    /// </summary>
    public TicketType TicketTypeId { get; set; }
    /// <summary>
    /// Internet = 5
    /// , Operator = 6 
    /// , Stand = 7
    /// </summary>
    public CreateType CreateTypeId { get; set; }


    public DateOnly? StartDate { get; set; }
    /// <summary>
    /// if Regolar or New  => CreateDate == EndDate
    /// else EndDate = Any
    /// </summary>
    public DateOnly? EndDate { get; set; }
    #endregion

}

