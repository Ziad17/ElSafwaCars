using System;

namespace Carproject.Entities;

public partial class Contr
{
    public uint Id { get; set; }

    public string Name { get; set; } = null!;

    public string Number { get; set; } = null!;

    public int TotalCash { get; set; }

    public DateTime NextPayDate { get; set; }

    public DateTime CreateDate { get; set; }

    public string? Notes { get; set; }

    public bool Stat { get; set; }

    public string? Duration { get; set; }

    public int WithdrawNum { get; set; }

    public int ProftNum { get; set; }
}
