using System;
using System.Collections.Generic;
using System.Reactive.Subjects;

namespace Common.Ddd.Infrastructure.Event.Implementation
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

        public void Publish(IDomainEvent domainEvent)
        {
            foreach (Subject<IDomainEvent> subject in subjects)
            {
                subject.OnNext(domainEvent);
            }
        }
    }
}