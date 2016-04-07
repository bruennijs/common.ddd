using System;
using System.Collections.Generic;
using System.Reactive.Subjects;
using common.ddd.Infrastructure.Event;

namespace common.ddd.Infrastructure.Event.Implementation
{
  public class DomainEventsBus : IDomainEventBus
  {
    private IList<Subject<IDomainEvent>> subjects = new List<Subject<IDomainEvent>>();

    public IObservable<IDomainEvent> Subscribe()
    {
      Subject<IDomainEvent> subject = new Subject<IDomainEvent>();
      subjects.Add(subject);
      return subject;
    }
  }
}