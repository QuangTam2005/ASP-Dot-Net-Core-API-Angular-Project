using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KwanTam.BackendServer.Data.Interfaces;

namespace KwanTam.BackendServer.Data.Entities;

[Table("Reports")]
// Entity đại diện cho bảng Reports.
public class Report : IDateTracking
{
    // [Key] cho EF Core biết Id là khóa chính của bảng.
    [Key]
    // SQL Server sẽ tự tăng giá trị Id khi thêm bản ghi.
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    // Khóa ngoại đến KnowledgeBase.
    public int KnowledgeBaseId { get; set; }

    // Khóa ngoại đến User tạo report.
    public int ReportUserId { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(max)")]
    public string Content { get; set; } = string.Empty;

    public string Status { get; set; } = string.Empty;
    public DateTime CreateDate { get; set; }
    public DateTime? LastModifiedDate { get; set; }

    // Navigation property đến KnowledgeBase.
    public KnowledgeBase KnowledgeBase { get; set; } = null!;

    // Navigation property đến User tạo report.
    public User ReportUser { get; set; } = null!;
}
