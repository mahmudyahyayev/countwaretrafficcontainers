﻿using Convey.CQRS.Events;
using CountwareTraffic.Services.Events.Application;
using Microsoft.Extensions.Logging;
using Mhd.Framework.Ioc;
using Mhd.Framework.Queue;
using System;
using System.Threading.Tasks;

namespace CountwareTraffic.Services.Events.Api
{
    public class DeviceDeletedConsumer : IConsumer<Mhd.Framework.QueueModel.DeviceDeleted>, ITransientSelfDependency
    {
        private readonly IEventMapper _eventMapper;
        private readonly IEventDispatcher _eventDispatcher;
        private readonly ILogger<DeviceDeletedConsumer> _logger;

        public DeviceDeletedConsumer(IEventMapper eventMapper, IEventDispatcher eventDispatcher, ILogger<DeviceDeletedConsumer> logger)
        {
            _eventMapper = eventMapper;
            _eventDispatcher = eventDispatcher;
            _logger = logger;
        }
        public async Task ConsumeAsync(Mhd.Framework.QueueModel.DeviceDeleted queueEvent)
        {
            _logger.LogInformation($"Consumed delete Device with name {queueEvent.Name} with correlationId {queueEvent.CorrelationId}");
            var deviceDeleted = _eventMapper.Map(queueEvent) as DeviceDeleted;
            await _eventDispatcher.PublishAsync(deviceDeleted);
        }

        public void Dispose() => GC.SuppressFinalize(this);
    }
}
