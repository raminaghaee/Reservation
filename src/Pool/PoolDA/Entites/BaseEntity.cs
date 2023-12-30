using CMN;
using PoolBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolDA.Entites;
public class BaseEntity : IEntity
{
    public int Id { get ; set; }
    /// <summary>
    /// Active = 102 , Not Active = 103
    /// In Constant Table
    /// </summary>
    public int ActivedId { get ; set ; }
}

