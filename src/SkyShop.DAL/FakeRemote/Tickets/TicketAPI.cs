using System.Collections.Immutable;
using System.Text.Json;
using SkyShop.DAL.FakeRemote.DTOs;

namespace SkyShop.DAL.FakeRemote.Tickets;

public class TicketAPI(JsonSerializerOptions options)
{
    private readonly JsonSerializerOptions _options = options;
    public ImmutableList<TicketDTO> GetTickets()
    {
        var tickets = File.ReadAllText("D:\\projects\\SkyShop\\src\\SkyShop.DAL\\FakeRemote\\Tickets\\TicketSource.json");
        return JsonSerializer.Deserialize<List<TicketDTO>>(tickets, _options)?.ToImmutableList() ?? [];
    }
}
