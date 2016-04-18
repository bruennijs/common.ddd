using System;

namespace Common.Ddd.Infrastructure.Event.Implementation
{
    public class DomainEvent : IDomainEvent
    {
        ///
        /// Unique identifier of this event.
        ///
        public string Id { get; private set; }

        protected DomainEvent()
        {
            Id = Guid.NewGuid().ToString();
        }

        protected DomainEvent(string id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));
            Id = id;
        }
    }
}
