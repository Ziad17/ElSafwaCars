using System.ComponentModel.DataAnnotations;

namespace Carproject.Entities;

public partial class Password
{
    [Key]
    public int Id { get; set; }

    public string? CurrentPassword { get; set; }
}
