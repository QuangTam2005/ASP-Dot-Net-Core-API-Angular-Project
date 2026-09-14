using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KwanTam.BackendServer.Data.Interfaces;

namespace KwanTam.BackendServer.Data.Entities;

[Table("KnowledgeBases")]
// Bảng KnowledgeBases.
public class KnowledgeBase : IDateTracking
{
    // Id là khóa chính của bảng.
    [Key]
    // Tự tăng giá trị Id khi thêm bản ghi.
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    // Cho biết là dữ liệu bắt buộc.
    [Required]
    public string Title { get; set; } = string.Empty;

    // Xác định rõ kiểu cột SQL Server cho nội dung dài.
    [Column(TypeName = "nvarchar(max)")]
    public string? Description { get; set; }

    [Column(TypeName = "nvarchar(max)")]
    public string? Content { get; set; }

    [Column(TypeName = "nvarchar(max)")]
    public string? Problem { get; set; }

    [Column(TypeName = "nvarchar(250)")]
    public string? ErrorMessage { get; set; }

    [Column(TypeName = "nvarchar(max)")]
    public string? Environment { get; set; }

    [Column(TypeName = "nvarchar(max)")]
    public string? StepToReproduce { get; set; }

    [Column(TypeName = "nvarchar(max)")]
    public string? Cause { get; set; }

    [Column(TypeName = "nvarchar(max)")]
    public string? Resolution { get; set; }

    [Column(TypeName = "nvarchar(max)")]
    public string? Workaround { get; set; }

    [Column(TypeName = "nvarchar(max)")]
    public string? Note { get; set; }

    public int SortOrder { get; set; }
    public int? ParentId { get; set; }

    // Khóa ngoại đến Category; quan hệ này yêu cầu KnowledgeBase có CategoryId.
    public int CategoryId { get; set; }

    // Khóa ngoại đến User sở hữu bài viết.
    public int? OwnerUserId { get; set; }

    public string Status { get; set; } = string.Empty;
    public string? SeoAlias { get; set; }
    public string? SeoDescription { get; set; }
    public int NumberOfTickets { get; set; }
    public int NumberOfComments { get; set; }
    public int NumberOfVotes { get; set; }
    public int NumberOfReports { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? LastModifiedDate { get; set; }

    // [ForeignKey] liên kết navigation property với CategoryId.
    [ForeignKey(nameof(CategoryId))]
    // Navigation property đến Category.
    public Category Category { get; set; } = null!;

    // Navigation property đến User sở hữu bài viết.
    public User? OwnerUser { get; set; }

    // [ForeignKey] chỉ rõ ParentId là khóa ngoại tự tham chiếu.
    [ForeignKey(nameof(ParentId))]
    // Navigation property tự tham chiếu để biểu diễn bài viết cha/con.
    public KnowledgeBase? Parent { get; set; }
    public ICollection<KnowledgeBase> Children { get; set; } = new List<KnowledgeBase>();

    // Collection được khởi tạo để tránh lỗi null khi truy cập dữ liệu liên quan.
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    public ICollection<Vote> Votes { get; set; } = new List<Vote>();
    public ICollection<Report> Reports { get; set; } = new List<Report>();
    public ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();
    public ICollection<LabelInKnowledgeBase> LabelLinks { get; set; } = new List<LabelInKnowledgeBase>();
}
