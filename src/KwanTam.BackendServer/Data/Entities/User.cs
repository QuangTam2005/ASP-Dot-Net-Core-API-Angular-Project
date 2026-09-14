using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KwanTam.BackendServer.Data.Entities;

[Table("Users")]
// Entity đại diện cho bảng Users.
public class User
{
    // [Key] cho EF Core biết Id là khóa chính của bảng.
    [Key]
    // SQL Server sẽ tự tăng giá trị Id khi thêm bản ghi.
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    public string LastName { get; set; } = string.Empty;

    // Collection được khởi tạo để tránh lỗi null khi truy cập dữ liệu liên quan.
    public ICollection<KnowledgeBase> OwnedKnowledgeBases { get; set; } = new List<KnowledgeBase>();
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    public ICollection<Vote> Votes { get; set; } = new List<Vote>();
    public ICollection<Report> Reports { get; set; } = new List<Report>();
    public ICollection<ActivityLog> ActivityLogs { get; set; } = new List<ActivityLog>();
}
