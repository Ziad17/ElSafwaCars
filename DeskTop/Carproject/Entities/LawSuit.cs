using System;

namespace Carproject.Entities;

public partial class LawSuit
{
    public uint Id { get; set; }

    public string? CaseNumber { get; set; }

    public string? InventoryNumber { get; set; }

    public string? Judgement { get; set; }

    public DateTime? OpposingSessionDate { get; set; }

    public string? OpposingSessionJudgement { get; set; }

    public string? LawyerName { get; set; }

    public string? CaseCreator { get; set; }

    public string? Guarantor { get; set; }

    public uint? BillId { get; set; }

    public DateTime? CreationDate { get; set; }

    public virtual Bill? Bill { get; set; }
}
