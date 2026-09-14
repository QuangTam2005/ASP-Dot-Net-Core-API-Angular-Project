using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KwanTam.BackendServer.Data.Entities;

[Table("Categories")]
// Entity đại diện cho bảng Categories.
public class Category
{
    // [Key] cho EF Core biết Id là khóa chính của bảng.
    [Key]
    // SQL Server sẽ tự tăng giá trị Id khi thêm bản ghi.
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    // Khóa ngoại tự tham chiếu đến danh mục cha; dấu ? cho biết có thể không có danh mục cha.
    public int? ParentId { get; set; }

    // [ForeignKey] chỉ rõ ParentId là khóa ngoại tự tham chiếu.
    [ForeignKey(nameof(ParentId))]
    // Navigation property tự tham chiếu của Category.
    public Category? Parent { get; set; }
    public ICollection<Category> Children { get; set; } = new List<Category>();

    // Collection được khởi tạo để tránh lỗi null khi truy cập các bài viết thuộc danh mục.
    public ICollection<KnowledgeBase> KnowledgeBases { get; set; } = new List<KnowledgeBase>();
}
