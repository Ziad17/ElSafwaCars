using System;

namespace Carproject.Entities;

public partial class FinishBill
{
    public uint BillId { get; set; }

    public DateTime? Date { get; set; }

    public int? Price { get; set; }

    public string? CarNumber { get; set; }

    public string? CarModel { get; set; }

    public string? CarMotor { get; set; }

    public string? CarMark { get; set; }

    public string? ShasehNumber { get; set; }

    public virtual Bill Bill { get; set; } = null!;
}
