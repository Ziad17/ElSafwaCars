using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Carproject.Entities;

[Table("bills")]
public class Bill
{
    [Column("id")]
    [Key]
    public int Id { get; set; }

    [Column("Buyer_name")]
    public string? BuyerName { get; set; }

    [Column("Buyer_phone")]
    public string BuyerPhone { get; set; } = null!;
    [Column("Inserunce_phone")]
    public string InseruncePhone { get; set; } = null!;
    [Column("Restrict_sell_for")]

    public string? RestrictSellFor { get; set; }

    public string? Notes { get; set; }

    [Column("Total_price")]
    public uint TotalPrice { get; set; }
    [Column("Paid_price")]

    public uint PaidPrice { get; set; }
    [Column("To_pay_price")]
    public uint ToPayPrice { get; set; }
    [Column("First_pay_date")]

    public DateTime? FirstPayDate { get; set; }
    [Column("car_number")]
    public string? CarNumber { get; set; }
    [Column("created_date")]

    public DateTime CreatedDate { get; set; }

    public bool? Going { get; set; }
    [Column("stop_date")]

    public DateTime? StopDate { get; set; }

    public bool Hidden { get; set; }

    public bool Dead { get; set; }

    //public virtual Car? CarNumberNavigation { get; set; }

    //public virtual ICollection<Car> Cars { get; set; } = new List<Car>();

    //public virtual ICollection<Install> Installs { get; set; } = new List<Install>();

    //public virtual ICollection<LawSuit> LawSuits { get; set; } = new List<LawSuit>();

    //public virtual ICollection<SubInstall> SubInstalls { get; set; } = new List<SubInstall>();
}
