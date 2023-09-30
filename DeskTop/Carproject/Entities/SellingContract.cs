using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Carproject.Entities;

[Table("selling_contract")]
public partial class SellingContract
{
    [Key]
    public int Id { get; set; }
    [Column("Buyer_name")]

    public string? BuyerName { get; set; }

    [Column("Buyer_card")]
    public string? BuyerCard { get; set; }

    [Column("Buyer_address")]
    public string? BuyerAddress { get; set; }

    [Column("Seller_name")]
    public string? SellerName { get; set; }

    [Column("Seller_card")]
    public string? SellerCard { get; set; }

    [Column("Seller_address")]
    public string? SellerAddress { get; set; }

    [Column("Car_number")]
    public string? CarNumber { get; set; }
    [Column("Car_model")]
    public string? CarModel { get; set; }
    [Column("Car_mark")]

    public string? CarMark { get; set; }
    [Column("Car_shaseh")]

    public string? CarShaseh { get; set; }
    [Column("Car_motor")]

    public string? CarMotor { get; set; }
    [Column("Car_kind")]

    public string? CarKind { get; set; }
    [Column("Car_color")]

    public string? CarColor { get; set; }
    [Column("Car_shape")]

    public string? CarShape { get; set; }

    //public int? TotalPrice { get; set; }

    //public int? PaidPrice { get; set; }

    //public int? RemainPrice { get; set; }

    //public int? DailyRent { get; set; }

    //public string? PenaltyClause { get; set; }

    //public DateTime? AuthDate { get; set; }

    [Column("Created_date")]
    public DateTime? CreatedDate { get; set; }

    //public DateTime? CreatedTime { get; set; }
}
