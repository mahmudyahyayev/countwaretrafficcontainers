﻿using System;

namespace CountwareTraffic.Services.Devices.Application
{
    public class DeviceDeletedRejected : Convey.CQRS.Events.IEvent
    {
        public Guid DeviceId { get; init; }
        public Guid UserId { get; set; }
    }
}
