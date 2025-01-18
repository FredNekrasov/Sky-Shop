namespace SkyShop.DAL.FakeRemote.Tickets;

internal class TicketAPIFactoryMethod : AbsAPIFactoryMethod<TicketAPI>
{
    public override TicketAPI NewInstance()
    {
        return new(GetJsonSerializerOptions());
    }
}
