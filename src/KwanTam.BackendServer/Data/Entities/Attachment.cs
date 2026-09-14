using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KwanTam.BackendServer.Data.Interfaces;

namespace KwanTam.BackendServer.Data.Entities;

[Table("Attachments")]
// Entity đại diện cho bảng Attachments, lưu thông tin tệp đính kèm.
public class Attachment : IDateTracking
{
    // [Key] cho EF Core biết Id là khóa chính của bảng.
    [Key]
    // SQL Server sẽ tự tăng giá trị Id khi thêm bản ghi.
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    // [Required] cho biết đường dẫn tệp là dữ liệu bắt buộc.
    [Required]
    public string AttachFilePath { get; set; } = string.Empty;

    public string? FileType { get; set; }
    public long FileSize { get; set; }

    [Required]
    public string FileName { get; set; } = string.Empty;

    // Khóa ngoại có thể trỏ đến KnowledgeBase hoặc Comment tùy loại tệp.
    public int? KnowledgeBaseId { get; set; }
    public int? CommentId { get; set; }
    public string? Type { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? LastModifiedDate { get; set; }

    // Navigation property đến KnowledgeBase, nếu tệp thuộc về bài viết.
    public KnowledgeBase? KnowledgeBase { get; set; }

    // Navigation property đến Comment, nếu tệp thuộc về bình luận.
    public Comment? Comment { get; set; }
}
