using CMN;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace PoolBL;
public class BaseEntity : IEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get ; set; }
    /// <summary>
    /// Active = 1 , Not Active = 2
    /// In Constant Table
    /// </summary>
    public int ActivedId { get ; set ; }
}

