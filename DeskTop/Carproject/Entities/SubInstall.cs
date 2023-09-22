using System;

namespace Carproject.Entities;

public partial class SubInstall
{
    public int Id { get; set; }

    public uint BillId { get; set; }

    public int InstallId { get; set; }

    public int Price { get; set; }

    public DateTime DatePaid { get; set; }

    public virtual Bill Bill { get; set; } = null!;

    public virtual Install Install { get; set; } = null!;
}
