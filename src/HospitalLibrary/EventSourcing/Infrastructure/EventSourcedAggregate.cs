﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLibrary.EventSourcing.Infrastructure
{
    public abstract class EventSourcedAggregate
    {
        public int Id { get; protected set; }
        public List<DomainEvent> Changes { get; private set; }
        public int Version { get; protected set; }

        public EventSourcedAggregate()
        {
            Changes = new List<DomainEvent>();
        }

        public abstract void Apply(DomainEvent @event);

    }
}
