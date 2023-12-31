using CMN;

namespace PoolBL;
public class DtoEmployee : IBaseDto
{
    /// <summary>
    /// Active = 102 , Not Active = 103
    /// In Constant Table
    /// </summary>
    public int ActivedId { get; set; }
    public decimal Salary { get; set; }
}
