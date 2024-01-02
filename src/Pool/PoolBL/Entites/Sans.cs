using System.ComponentModel.DataAnnotations.Schema;

namespace PoolBL;

[Table("Sans", Schema = "Pool")]
public class Sans : BaseEntity
{
    #region Realation
    public ICollection<Reserved> Reserved { get; set; }
    public int PoolId { get; set; }
    public Pool Pool { get; set; }
    #endregion

    #region Property
    /// <summary>
    /// in Constant Table
    /// </summary>
    public DayOfWeek DayOfWeekId { get; set; }

    public string StartTime { get; set; }

    public string EndTime { get; set; }

    public ushort Capacity { get; set; }
    #endregion

}

