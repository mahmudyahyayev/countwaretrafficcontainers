﻿using Convey.CQRS.Commands;
using System;

namespace CountwareTraffic.Services.Events.Infrastructure
{
    public class ProcessOutbox : ICommand
    {
        public Guid RecordId { get; set; }
        public string ExceptionMessage { get; set; }
    }
}
