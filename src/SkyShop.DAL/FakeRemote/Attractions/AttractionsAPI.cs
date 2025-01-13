using SkyShop.DAL.FakeRemote.DTOs;
using System.Collections.Immutable;
using System.Text.Json;

namespace SkyShop.DAL.FakeRemote.Attractions;

public class AttractionsAPI
{
    public static ImmutableList<AttractionDTO> GetAttractions()
    {
        var attractions = File.ReadAllText("AttractionsSource.json");
        return JsonSerializer.Deserialize<List<AttractionDTO>>(attractions)?.ToImmutableList() ?? [];
    }
}
