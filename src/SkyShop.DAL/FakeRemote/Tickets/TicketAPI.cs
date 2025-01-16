using System.Collections.Immutable;
using System.Text.Json;
using SkyShop.DAL.FakeRemote.DTOs;

namespace SkyShop.DAL.FakeRemote.Tickets;

public class TicketAPI
{
    public static ImmutableList<TicketDTO> GetTickets()
    {
        var tickets = File.ReadAllText("TicketSource.json");
        return JsonSerializer.Deserialize<List<TicketDTO>>(tickets)?.ToImmutableList() ?? [];
    }
}
