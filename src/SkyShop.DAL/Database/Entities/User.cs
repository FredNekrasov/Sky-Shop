using Microsoft.EntityFrameworkCore;

namespace SkyShop.DAL.Database.Entities;

[PrimaryKey(nameof(Id))]
public class User
{
    public int Id { get; set; }
    public string UserName { get; set; } = string.Empty;
    public DateTime Birthday { get; set; } = DateTime.Now!;
    public string Password { get; set; } = string.Empty;
    public string Mail { get; set; } = string.Empty;
    public bool IsActive { get; set; }
    public Profile Profile { get; set; } = null!;
}
