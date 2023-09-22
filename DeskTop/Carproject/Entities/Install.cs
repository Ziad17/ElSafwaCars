using System;
using System.Collections.Generic;

namespace Carproject.Entities;

public partial class Install
{
    public int Id { get; set; }

    public uint BillId { get; set; }

    public int TotalPrice { get; set; }

    public int ToPayPrice { get; set; }

    public int PaidPrice { get; set; }

    public bool Stat { get; set; }

    public DateTime? PayingDate { get; set; }

    public string? Notes { get; set; }

    public bool ReturnDept { get; set; }

    public virtual Bill Bill { get; set; } = null!;

    public virtual ICollection<SubInstall> SubInstalls { get; set; } = new List<SubInstall>();
}
