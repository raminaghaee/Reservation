using CMN;

namespace PoolBL;
public interface IPool : IEntity
{
    string Name { get; set; }
    string Address { get; set; }
    string? PhoneNumber { get; set; }
}
