using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KwanTam.BackendServer.Data.Entities;

[Table("ActivityLogs")]
// Entity đại diện cho bảng ActivityLogs, dùng để lưu lịch sử thao tác.
public class ActivityLog
{
    // [Key] cho EF Core biết Id là khóa chính của bảng.
    [Key]
    // SQL Server sẽ tự tăng giá trị Id khi thêm bản ghi.
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    // [Column] xác định rõ kiểu cột SQL Server cho nội dung dài.
    [Column(TypeName = "nvarchar(max)")]
    public string? Content { get; set; }

    // Thời điểm hoạt động được ghi nhận.
    public DateTime CreateDate { get; set; }

    // Khóa ngoại tham chiếu đến người thực hiện thao tác.
    public int? UserId { get; set; }

    // [Required] cho biết cột không được phép nhận giá trị null.
    [Required]
    public string Action { get; set; } = string.Empty;

    [Required]
    public string EntityName { get; set; } = string.Empty;

    public int EntityId { get; set; }

    // Navigation property đến User; không dùng virtual vì project không dùng lazy loading.
    public User? User { get; set; }
}
