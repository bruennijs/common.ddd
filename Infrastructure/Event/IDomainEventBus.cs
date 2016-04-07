using System;

namespace common.ddd.Infrastructure.Event
{
  public interface IDomainEventBus
  {
    IObservable<IDomainEvent> Subscribe();
  }
}