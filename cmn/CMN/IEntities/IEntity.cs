using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CMN.Enums;

namespace CMN;
public interface IEntity
{ 
    int Id { get; set; }
    IsActived ActivedId { get; set; }
}

