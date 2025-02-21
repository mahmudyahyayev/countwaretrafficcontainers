﻿using CountwareTraffic.Services.Events.Application;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CountwareTraffic.Services.Events.Infrastructure
{
    public class QueueEventMapper : IQueueEventMapper
    {
        private readonly ICorrelationService _correlationService;
        public QueueEventMapper(ICorrelationService correlationService)
        {
            _correlationService = correlationService;
        }
        public List<Mhd.Framework.Queue.IQueueEvent> MapAll(IEnumerable<Mhd.Framework.Efcore.IDomainEvent> events, Guid userId)
               => events.Select(e => Map(e, userId)).ToList();

        public Mhd.Framework.Queue.IQueueEvent Map(Mhd.Framework.Efcore.IDomainEvent @event, Guid userId)
        {
            switch (@event)
            {
                case Core.EventCreateCompleted e:
                    return new Mhd.Framework.QueueModel.EventCreated()
                    {
                        Description = e.Description,
                        DeviceId = e.DeviceId,
                        EventDate = e.EventDate,
                        DeviceName = e.DeviceName,
                        DirectionTypeId = e.DirectionTypeId,
                        DirectionTypeName = e.DirectionTypeName,
                        EventId = e.EventId,
                        CreateDate = e.CreateDate,
                        CreateBy = e.CreateBy,
                        RecordId = e.RecordId,
                        UserId = userId,
                        CorrelationId = _correlationService.CorrelationId
                    };
            }

            return null;
        }
        public void Dispose() => GC.SuppressFinalize(this);
    }
}
