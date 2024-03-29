﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Carproject.Entities;

public partial class Withdarw
{
    [Key]
    public int Id { get; set; }

    public uint ContrId { get; set; }

    public int? WithdrawValue { get; set; }

    public string? Notes { get; set; }

    public DateTime WithdrawDate { get; set; }

    public bool? Withdraw { get; set; }

    public virtual Contr Contr { get; set; } = null!;
}
