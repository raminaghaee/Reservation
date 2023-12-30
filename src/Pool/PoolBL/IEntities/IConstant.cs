using CMN;

namespace PoolBL;
public interface IConstant : IEntity
{
    public int Id { get; set; }
    string Title { get; set; }
    int IsActived { get; set; } //=102;
    string TypeName { get; set; }
    string Value { get; set; }
}
