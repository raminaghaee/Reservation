using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PoolBL;

[Table("Constant", Schema ="Pool")]
public class Constant : BaseEntity
{
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

