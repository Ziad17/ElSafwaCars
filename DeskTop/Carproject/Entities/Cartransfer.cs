using System;
using System.ComponentModel.DataAnnotations;

namespace Carproject.Entities;

public partial class Cartransfer
{
    [Key]
    public uint Id { get; set; }

    public uint? BillId { get; set; }

    public DateTime Date { get; set; }

    public string? CarNumber { get; set; }

    public bool Added { get; set; }

    public string? Place { get; set; }

    public string? BuyerName { get; set; }
}
