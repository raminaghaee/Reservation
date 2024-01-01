using CMN;
using System.ComponentModel.DataAnnotations;

namespace PoolBL;
public class DtoConstant : IBaseDto
{
    /// <summary>
    /// Active = 102 , Not Active = 103
    /// In Constant Table
    /// </summary>
    public int ActivedId { get; set; }
    [Required]
    [MaxLength(20)]
    public string Title { get; set; }

    [Required]
    [MaxLength(20)]
    public string TypeName { get; set; }

    [MaxLength(50)]
    public string? Value { get; set; }

    [Required]
    [MaxLength(20)]
    public string SubSistem { get; set; }
}
