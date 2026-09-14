using System.ComponentModel.DataAnnotations.Schema;

namespace KwanTam.BackendServer.Data.Entities;

[Table("Votes")]
// Entity đại diện cho bảng nối giữa KnowledgeBases và Users.
public class Vote
{
    // Khóa ngoại đến KnowledgeBase; cùng UserId tạo thành khóa chính kép.
    public int KnowledgeBaseId { get; set; }

    // Khóa ngoại đến User; không đặt [Key] riêng vì đây là khóa ghép.
    public int UserId { get; set; }

    public int Type { get; set; }
    public DateTime CreateDate { get; set; }

    // Navigation property đến KnowledgeBase.
    public KnowledgeBase KnowledgeBase { get; set; } = null!;

    // Navigation property đến User.
    public User User { get; set; } = null!;
}
