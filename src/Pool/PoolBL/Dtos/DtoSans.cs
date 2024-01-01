using CMN;
using System.ComponentModel.DataAnnotations.Schema;

namespace PoolBL;
public class DtoSans : IBaseDto
{
    public int PoolId { get; set; }
    /// <summary>
    /// Active = 102 , Not Active = 103
    /// In Constant Table
    /// </summary>
    public int ActivedId { get; set; }

    /// <summary>
    /// in Constant Table
    /// </summary>
    public int DayOfWeekId { get; set; }

    public string StartTime { get; set; }

    public string EndTime { get; set; }

    public ushort Capacity { get; set; }
}
