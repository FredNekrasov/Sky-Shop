using SkyShop.DAL.FakeRemote.DTOs;
using System.Collections.Immutable;
using System.Text.Json;

namespace SkyShop.DAL.FakeRemote.Attractions;

public class AttractionsAPI(JsonSerializerOptions options)
{
    private readonly JsonSerializerOptions _options = options;
    public ImmutableList<AttractionDTO> GetAttractions()
    {
        var attractions = File.ReadAllText("D:\\projects\\SkyShop\\src\\SkyShop.DAL\\FakeRemote\\Attractions\\AttractionsSource.json");
        return JsonSerializer.Deserialize<List<AttractionDTO>>(attractions, _options)?.ToImmutableList() ?? [];
    }
}
