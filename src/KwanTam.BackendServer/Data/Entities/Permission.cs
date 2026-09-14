using System.ComponentModel.DataAnnotations.Schema;

namespace KwanTam.BackendServer.Data.Entities;

[Table("Permissions")]
// Entity đại diện cho bảng nối phân quyền theo Role, Function và Command.
public class Permission
{
    // Khóa ngoại đến Role; cùng hai property bên dưới tạo thành khóa chính kép gồm ba cột.
    public int RoleId { get; set; }

    // Khóa ngoại đến Function; không đặt [Key] riêng vì đây là khóa ghép.
    public int FunctionId { get; set; }

    // Khóa ngoại đến Command; không đặt [Key] riêng vì đây là khóa ghép.
    public int CommandId { get; set; }

    // Navigation property đến Function.
    public Function Function { get; set; } = null!;

    // Navigation property đến Command.
    public Command Command { get; set; } = null!;
}
