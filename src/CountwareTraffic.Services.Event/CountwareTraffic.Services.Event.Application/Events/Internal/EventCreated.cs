﻿using System;

namespace CountwareTraffic.Services.Events.Application
{
    public class EventCreated : Convey.CQRS.Events.IEvent
    {
        public Guid DeviceId { get; set; }
        public Guid EventId { get; set; }
        public string DeviceName { get; set; }
        public int DirectionTypeId { get; set; }
        public string DirectionTypeName { get; set; }
        public string Description { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid CreateBy { get; set; }
        public Guid UserId { get; init; }
    }
}
