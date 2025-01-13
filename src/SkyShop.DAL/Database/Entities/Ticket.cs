namespace SkyShop.DAL.Database.Entities;

public class Ticket
{
    public int Id { get; set; }
    public string StartCity { get; set; } = string.Empty;
    public string StartCityCode { get; set; } = string.Empty;
    public string EndCity { get; set; } = string.Empty;
    public string EndCityCode { get; set; } = string.Empty;
    public DateTime StartDate { get; set; } = DateTime.MinValue;
    public DateTime EndDate { get; set; } = DateTime.MinValue;
    public int Price { get; set; }
}
