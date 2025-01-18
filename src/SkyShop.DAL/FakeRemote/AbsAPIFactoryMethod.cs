using System.Text.Json;

namespace SkyShop.DAL.FakeRemote;

public abstract class AbsAPIFactoryMethod<T>
{
    protected static JsonSerializerOptions GetJsonSerializerOptions() => new()
    {
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };
    public abstract T NewInstance();
}
