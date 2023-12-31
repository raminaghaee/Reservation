using CMN;
using System.ComponentModel.DataAnnotations.Schema;

namespace PoolBL;
public class DtoSans : IBaseDto
{
    /// <summary>
    /// Active = 102 , Not Active = 103
    /// In Constant Table
    /// </summary>
    public int ActivedId { get; set; }

    /// <summary>
    /// in Constant Table
    /// </summary>
    public int DayOfWeekId { get; set; }

    [Column(TypeName = "NCHAR(5)")]
    public string StartTime { get; set; }

    [Column(TypeName = "NCHAR(5)")]
    public string EndTime { get; set; }

    public ushort Capacity { get; set; }
}
