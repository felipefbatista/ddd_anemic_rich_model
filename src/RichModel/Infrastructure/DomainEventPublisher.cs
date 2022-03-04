using RichModel.Domain.Events;
using System;

namespace RichModel.Domain
{
    public static class DomainEventPublisher
    {
        public static void Publish(BacklogItemCommitted @event)
        {
            Console.WriteLine("Evento 'BacklogItemCommitted' publicado");
        }

        public static void Publish(BacklogItemUncommitFromSprint @event)
        {
            Console.WriteLine("Evento 'BacklogItemUncommitFromSprint' publicado");
        }
    }
}