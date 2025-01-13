using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkyShop.DAL.Database.Entities;

[PrimaryKey(nameof(Id))]
public class Profile
{
    public int Id { get; set; }
    [ForeignKey(nameof(UserId))]
    public int UserId { get; set; }
    public string Surname { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Patronymic { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    public string Question { get; set; } = string.Empty;
    public string Answer { get; set; } = string.Empty;
    public string Photo { get; set; } = string.Empty;
    public User User { get; set; } = null!;
}
