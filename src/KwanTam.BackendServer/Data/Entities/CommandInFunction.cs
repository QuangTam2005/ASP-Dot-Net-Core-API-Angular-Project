using System.ComponentModel.DataAnnotations.Schema;

namespace KwanTam.BackendServer.Data.Entities;

[Table("CommandInFunctions")]
// Entity đại diện cho bảng nối giữa Commands và Functions.
public class CommandInFunction
{
    // Khóa ngoại đến Function; hai khóa này tạo thành khóa chính kép.
    public int FunctionId { get; set; }

    // Khóa ngoại đến Command; không đặt [Key] riêng vì đây là khóa ghép.
    public int CommandId { get; set; }

    // Navigation property đến Function.
    public Function Function { get; set; } = null!;

    // Navigation property đến Command.
    public Command Command { get; set; } = null!;
}
