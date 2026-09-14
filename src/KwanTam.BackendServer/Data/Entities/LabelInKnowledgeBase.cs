using System.ComponentModel.DataAnnotations.Schema;

namespace KwanTam.BackendServer.Data.Entities;

[Table("LabelInKnowledgeBase")]
// Entity đại diện cho bảng nối giữa Labels và KnowledgeBases.
public class LabelInKnowledgeBase
{
    // Khóa ngoại đến KnowledgeBase; không đặt [Key] riêng vì đây là khóa ghép.
    public int KnowledgeBaseId { get; set; }

    // Khóa ngoại đến Label; hai khóa này tạo thành khóa chính kép.
    public int LabelId { get; set; }

    // Navigation property đến KnowledgeBase.
    public KnowledgeBase KnowledgeBase { get; set; } = null!;

    // Navigation property đến Label.
    public Label Label { get; set; } = null!;
}
