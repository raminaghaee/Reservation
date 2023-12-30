using CMN;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolBL;
public interface IPay : IEntity
{
    
    string CreateDate { get; set; }
    string CreateTime { get; set; }
    int TicketTypeId { get; set; }
    int PayTypeId { get; set; }
    int CreateTypeId { get; set; }
   
}
