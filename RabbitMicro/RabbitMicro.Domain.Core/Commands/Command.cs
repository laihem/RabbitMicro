using RabbitMicro.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMicro.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; set; }

        public Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
