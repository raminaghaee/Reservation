using CMN;
using System.ComponentModel.DataAnnotations;

namespace PoolBL;
public class dtoConstant : IBaseDto
{
    /// <summary>
    /// Active = 102 , Not Active = 103
    /// In Constant Table
    /// </summary>
    public int ActivedId { get; set; }
    [Required]
    [MaxLength(20)]
    public string Title { get; set; }
    public int IsActived { get; set; } //=102;

    [Required]
    [MaxLength(20)]
    public string TypeName { get; set; }

    [MaxLength(50)]
    public string Value { get; set; }
}
