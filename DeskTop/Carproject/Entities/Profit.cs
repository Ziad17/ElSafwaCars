using System;

namespace Carproject.Entities;

public partial class Profit
{
    public int Id { get; set; }

    public uint ContrId { get; set; }

    public DateTime PayingDate { get; set; }

    public int PayValue { get; set; }

    public string? Notes { get; set; }

    public virtual Contr Contr { get; set; } = null!;
}
