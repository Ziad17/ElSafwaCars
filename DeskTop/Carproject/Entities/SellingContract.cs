using System;

namespace Carproject.Entities;

public partial class SellingContract
{
    public uint Id { get; set; }

    public string? BuyerName { get; set; }

    public string? BuyerCard { get; set; }

    public string? BuyerAddress { get; set; }

    public string? SellerName { get; set; }

    public string? SellerCard { get; set; }

    public string? SellerAddress { get; set; }

    public string? CarNumber { get; set; }

    public string? CarModel { get; set; }

    public string? CarMark { get; set; }

    public string? CarShaseh { get; set; }

    public string? CarMotor { get; set; }

    public string? CarKind { get; set; }

    public string? CarColor { get; set; }

    public string? CarShape { get; set; }

    public int? TotalPrice { get; set; }

    public int? PaidPrice { get; set; }

    public int? RemainPrice { get; set; }

    public int? DailyRent { get; set; }

    public string? PenaltyClause { get; set; }

    public DateTime? AuthDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? CreatedTime { get; set; }
}
