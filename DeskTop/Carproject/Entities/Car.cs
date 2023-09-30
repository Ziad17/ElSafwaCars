using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Carproject.Entities;

[Table("cars")]
public partial class Car
{
    [Column("Car_model")]
    public string? CarModel { get; set; }

    [Column("Car_Number")]
    [Key]
    public string CarNumber { get; set; } = null!;
    [Column("Motor_number")]
    public string? MotorNumber { get; set; }
    [Column("Car_mark")]
    public string? CarMark { get; set; }
    [Column("Shaseh_number")]
    public string? ShasehNumber { get; set; }

    public bool Registered { get; set; }

    public int? Price { get; set; }

    public bool? Sold { get; set; }
    [Column("created_date")]
    public DateTime? CreatedDate { get; set; }

    public string? Location { get; set; }

    [Column("bill_id")]
    public uint? BillId { get; set; }

}
