using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KwanTam.BackendServer.Data.Interfaces;

namespace KwanTam.BackendServer.Data.Entities;

[Table("Comments")]
// Entity đại diện cho bảng Comments.
public class Comment : IDateTracking
{
    // [Key] cho EF Core biết Id là khóa chính của bảng.
    [Key]
    // SQL Server sẽ tự tăng giá trị Id khi thêm bản ghi.
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    // [Required] cho biết nội dung bình luận là dữ liệu bắt buộc.
    [Required]
    // [Column] xác định rõ kiểu cột SQL Server cho nội dung dài.
    [Column(TypeName = "nvarchar(max)")]
    public string Content { get; set; } = string.Empty;

    // Khóa ngoại bắt buộc đến bài viết kiến thức.
    public int KnowledgeBaseId { get; set; }

    // Khóa ngoại bắt buộc đến người bình luận.
    public int OwnerUserId { get; set; }

    public string Status { get; set; } = string.Empty;
    public string? Type { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? LastModifiedDate { get; set; }

    // Navigation property đến KnowledgeBase.
    public KnowledgeBase KnowledgeBase { get; set; } = null!;

    // Navigation property đến User.
    public User User { get; set; } = null!;

    public ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();
}
