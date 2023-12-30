using PoolBL;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PoolDA;

[Table("Constant", Schema ="Pool")]
public class Constant : IConstant
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(20)]
    public string Title { get; set; }
    public int IsActived { get ; set; } //=102;

    [Required]
    [MaxLength(20)]
    public string TypeName { get; set; }

    [MaxLength(50)]
    public string Value { get; set; }
    public int ActivedId { get ; set; }
}

