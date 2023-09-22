using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Carproject.Entities;

public partial class Car
{
    public string? CarModel { get; set; }

    [Key]
    public string CarNumber { get; set; } = null!;

    public string? MotorNumber { get; set; }

    public string? CarMark { get; set; }

    public string? ShasehNumber { get; set; }

    public bool Registered { get; set; }

    public int? Price { get; set; }

    public bool? Sold { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Location { get; set; }

    public uint? BillId { get; set; }

    public virtual Bill? Bill { get; set; }

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();
}
