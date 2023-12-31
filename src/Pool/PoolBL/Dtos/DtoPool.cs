using CMN;
using System.ComponentModel.DataAnnotations;

namespace PoolBL;
public class DtoPool : IBaseDto
{
    /// <summary>
    /// Active = 102 , Not Active = 103
    /// In Constant Table
    /// </summary>
    public int ActivedId { get; set; }
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    [Required]
    [MaxLength(500)]
    public string Address { get; set; }

    [MaxLength(13)]
    public string? PhoneNumber { get; set; }
}
