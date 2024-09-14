﻿

namespace MedicalAppointment.Shared.Infrastructure.EventBus
{
    public interface IIntegrationEventHandler
    {
        public interface IIntegrationEventHandler<in TIntegrationEvent> : IIntegrationEventHandler
        where TIntegrationEvent : IntegrationEvent
        {
            Task Handle(TIntegrationEvent @event);
        }

        public interface IIntegrationEventHandler
        {
        }
    }
}
