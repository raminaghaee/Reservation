using CMN;
namespace PoolBL;
public interface ISans : IEntity
{
    int DayOfWeekId { get; set; }
    string StartTime { get; set; } 
    string EndTime { get; set; }
    ushort Capacity { get; set; }
}
