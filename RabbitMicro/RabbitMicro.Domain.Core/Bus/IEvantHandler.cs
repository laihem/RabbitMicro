using RabbitMicro.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMicro.Domain.Core.Bus
{
    public interface IEvantHandler<in TEvent> : IEvantHandler
        where TEvent :Event
    {
        Task Handle(TEvent @event);
    }

    public interface IEvantHandler
    {

    }
}
