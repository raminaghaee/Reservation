﻿using PoolBL;
using PoolDA.Entites;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PoolDA;

[Table("Sans", Schema = "Pool")]
public class Sans : BaseEntity,ISans
{
    #region Realation
    public ICollection<Reserved> Reserved { get; set; }
    public int PoolId { get; set; }
    public Pool Pool { get; set; }
    #endregion

    #region Property
    /// <summary>
    /// in Constant Table
    /// </summary>
    public int DayOfWeekId { get; set; }

    [Column(TypeName = "NCHAR(5)")]
    public string StartTime { get; set; }

    [Column(TypeName = "NCHAR(5)")]
    public string EndTime { get; set; }

    public ushort Capacity { get; set; }
    #endregion

}

