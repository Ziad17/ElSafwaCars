using System;

namespace Carproject.Entities;

public partial class Cartransfer
{
    public uint Id { get; set; }

    public uint? BillId { get; set; }

    public DateTime Date { get; set; }

    public string? CarNumber { get; set; }

    public bool Added { get; set; }

    public string? Place { get; set; }

    public string? BuyerName { get; set; }
}
