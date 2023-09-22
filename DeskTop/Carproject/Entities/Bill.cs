using System;
using System.Collections.Generic;

namespace Carproject.Entities;

public partial class Bill
{
    public uint Id { get; set; }

    public string? BuyerName { get; set; }

    public string BuyerPhone { get; set; } = null!;

    public string InseruncePhone { get; set; } = null!;

    public string? RestrictSellFor { get; set; }

    public string? Notes { get; set; }

    public uint TotalPrice { get; set; }

    public uint PaidPrice { get; set; }

    public uint ToPayPrice { get; set; }

    public DateTime? FirstPayDate { get; set; }

    public string? CarNumber { get; set; }

    public DateTime CreatedDate { get; set; }

    public bool? Going { get; set; }

    public DateTime? StopDate { get; set; }

    public bool Hidden { get; set; }

    public bool Dead { get; set; }

    public virtual Car? CarNumberNavigation { get; set; }

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();

    public virtual ICollection<Install> Installs { get; set; } = new List<Install>();

    public virtual ICollection<LawSuit> LawSuits { get; set; } = new List<LawSuit>();

    public virtual ICollection<SubInstall> SubInstalls { get; set; } = new List<SubInstall>();
}
