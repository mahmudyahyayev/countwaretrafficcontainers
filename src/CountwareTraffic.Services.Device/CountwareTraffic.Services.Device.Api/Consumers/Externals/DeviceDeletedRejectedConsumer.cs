﻿using Convey.CQRS.Events;
using CountwareTraffic.Services.Devices.Application;
using Mhd.Framework.Ioc;
using Mhd.Framework.Queue;
using System.Threading.Tasks;

namespace CountwareTraffic.Services.Devices.Api
{
    public class DeviceDeletedRejectedConsumer : IConsumer<Mhd.Framework.QueueModel.DeviceDeletedRejected>, ITransientSelfDependency
    {
        private readonly IEventDispatcher _eventDispatcher;
        private readonly IEventMapper _eventMapper;
        public DeviceDeletedRejectedConsumer(IEventDispatcher eventDispatcher, IEventMapper eventMapper)
        {
            _eventDispatcher = eventDispatcher;
            _eventMapper = eventMapper;
        }
        public async Task ConsumeAsync(Mhd.Framework.QueueModel.DeviceDeletedRejected queuEvent)
        {
            var deviceDeletedRejected = _eventMapper.Map(queuEvent) as DeviceDeletedRejected;
            await _eventDispatcher.PublishAsync(deviceDeletedRejected);
        }

        public void Dispose() => System.GC.SuppressFinalize(this);
    }
}
