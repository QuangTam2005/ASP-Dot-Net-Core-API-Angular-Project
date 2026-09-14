using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KwanTam.BackendServer.Data.Entities;

[Table("Labels")]
// Entity đại diện cho bảng Labels.
public class Label
{
    // [Key] cho EF Core biết Id là khóa chính của bảng.
    [Key]
    // SQL Server sẽ tự tăng giá trị Id khi thêm bản ghi.
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    // Collection navigation property đến bảng nối nhiều-nhiều.
    public ICollection<LabelInKnowledgeBase> KnowledgeBaseLinks { get; set; } = new List<LabelInKnowledgeBase>();
}
