using CMN;
using System.ComponentModel.DataAnnotations.Schema;

namespace PoolBL;
public interface IReserved : IEntity
{
    
    int IsConfirm { get; set; }

    string ConfirmDate { get; set; }

    string ConfirmTime { get; set; }

    string CreateDate { get; set; }
    string CreateTime { get; set; } 
    int CreateTypeId { get; set; }
}
