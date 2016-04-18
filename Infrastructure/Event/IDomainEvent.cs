namespace Common.Ddd.Infrastructure.Event
{
    public interface IDomainEvent
    {
        string Id { get; }
    }
}