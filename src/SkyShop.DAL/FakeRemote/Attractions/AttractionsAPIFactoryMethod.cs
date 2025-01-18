namespace SkyShop.DAL.FakeRemote.Attractions;

internal class AttractionsAPIFactoryMethod : AbsAPIFactoryMethod<AttractionsAPI>
{
    public override AttractionsAPI NewInstance()
    {
        return new(GetJsonSerializerOptions());
    }
}
