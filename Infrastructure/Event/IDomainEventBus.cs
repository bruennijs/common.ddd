using System;

namespace Common.Ddd.Infrastructure.Event
{
  public interface IDomainEventBus
  {
      IObservable<IDomainEvent> Subscribe();
      void Publish(IDomainEvent domainEvent);
  }
}