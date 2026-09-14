using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KwanTam.BackendServer.Data.Entities;

[Table("Functions")]
// Entity đại diện cho bảng Functions.
public class Function
{
    // [Key] cho EF Core biết Id là khóa chính của bảng.
    [Key]
    // SQL Server sẽ tự tăng giá trị Id khi thêm bản ghi.
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;
    public string? Url { get; set; }

    // Khóa ngoại tự tham chiếu đến function cha.
    public int? ParentId { get; set; }

    // [ForeignKey] chỉ rõ ParentId là khóa ngoại tự tham chiếu.
    [ForeignKey(nameof(ParentId))]
    // Navigation property tự tham chiếu của Function.
    public Function? Parent { get; set; }
    public ICollection<Function> Children { get; set; } = new List<Function>();

    public ICollection<Permission> Permissions { get; set; } = new List<Permission>();
    public ICollection<CommandInFunction> CommandLinks { get; set; } = new List<CommandInFunction>();
}
