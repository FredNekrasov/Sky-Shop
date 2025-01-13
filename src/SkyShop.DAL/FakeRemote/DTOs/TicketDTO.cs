namespace SkyShop.DAL.FakeRemote.DTOs;

public class TicketDTO
{
    public string StartCity { get; set; } = string.Empty;
    public string StartCityCode { get; set; } = string.Empty;
    public string EndCity { get; set; } = string.Empty;
    public string EndCityCode { get; set; } = string.Empty;
    public string StartDate { get; set; } = string.Empty;
    public string EndDate { get; set; } = string.Empty;
    public int Price { get; set; }
    public string SearchToken { get; set; } = string.Empty;
}
