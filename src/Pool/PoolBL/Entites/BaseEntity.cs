using CMN;


namespace PoolBL;
public class BaseEntity : IEntity
{
    public int Id { get ; set; }
    /// <summary>
    /// Active = 102 , Not Active = 103
    /// In Constant Table
    /// </summary>
    public int ActivedId { get ; set ; }
}

