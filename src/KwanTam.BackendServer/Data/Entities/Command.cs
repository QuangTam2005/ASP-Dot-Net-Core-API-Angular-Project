using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KwanTam.BackendServer.Data.Entities;

[Table("Commands")]
// Entity đại diện cho bảng Commands.
public class Command
{
    // [Key] cho EF Core biết Id là khóa chính của bảng.
    [Key]
    // SQL Server sẽ tự tăng giá trị Id khi thêm bản ghi.
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    // Collection là navigation property đến bảng nối nhiều-nhiều.
    public ICollection<CommandInFunction> FunctionLinks { get; set; } = new List<CommandInFunction>();
    public ICollection<Permission> Permissions { get; set; } = new List<Permission>();
}
