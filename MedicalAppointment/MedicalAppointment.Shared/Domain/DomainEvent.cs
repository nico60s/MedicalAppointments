﻿

using MediatR;

namespace MedicalAppointment.Shared.Domain
{
    public abstract class DomainEvent : IIntegrationEvent, INotification
    {
        private readonly Guid _id;
        public DateTime OccurredOn { get;  }
        public Guid Id => _id;
        protected DomainEvent()
        {
            _id = Guid.NewGuid();
            OccurredOn = DateTime.Now;  
        }

    }
}
