using System.ComponentModel.DataAnnotations.Schema;

namespace PoolBL;

[Table("Reserved", Schema = "Pool")]
public class Reserved : BaseEntity
{
    #region Realation
    public int PoolId { get; set; }
    //public Pool Pool { get; set; }


    public int SansId { get; set; }
    // public Sans Sans { get; set; }

    public int? UserId { get; set; }
    //public User User { get; set; }

    public int TicketId { get; set; }
    public Ticket Ticket { get; set; }

    public int? EmployeeId { get; set; }
    public Employee? Employee { get; set; }
    #endregion

    #region Properties
    /// <summary>
    /// Confirm = 3 ,  Not Confirm = 4
    /// in Constant table
    /// </summary>
    public int IsConfirm { get; set; }

    public DateTime ConfirmDateTime { get; set; }
    public DateTime DateTime { get; set; }

    /// <summary>
    /// Internet , Operator , Stand
    /// </summary>
    public int CreateTypeId { get; set; }
    #endregion

}

