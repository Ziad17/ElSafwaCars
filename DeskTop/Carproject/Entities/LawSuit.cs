using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Carproject.Entities;

[Table("LawSuit")]
public partial class LawSuit
{
    [Key]
    public int Id { get; set; }

    [DisplayName("رقم القضية")]
    public string? CaseNumber { get; set; }

    [DisplayName("رقم الحصر")]
    public string? InventoryNumber { get; set; }

    [DisplayName("الحكم")]
    public string? Judgement { get; set; }

    [DisplayName("جلسة المعارضة")]
    public DateTime? OpposingSessionDate { get; set; }

    [DisplayName("حكم المعارضة")]
    public string? OpposingSessionJudgement { get; set; }

    [DisplayName("المحامي")]
    public string? LawyerName { get; set; }

    [DisplayName("الشاكي")]
    public string? CaseCreator { get; set; }

    [DisplayName("الضامن")]
    public string? Guarantor { get; set; }

    [DisplayName("رقم الفاتورة")]
    public int BillId { get; set; }

    [DisplayName("تاريخ الإنشاء")]
    public DateTime? CreationDate { get; set; }

    public virtual Bill? Bill { get; set; }
}
