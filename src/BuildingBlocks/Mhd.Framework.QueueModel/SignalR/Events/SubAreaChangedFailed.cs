﻿using Mhd.Framework.Queue;
using System;

namespace Mhd.Framework.QueueModel
{
    public record SubAreaChangedFailed : IQueueEvent
    {
        public Guid SubAreaId { get; set; }
        public Guid UserId { get; set; }
        public string OldName { get; set; }
        public string NewName { get; set; }
        public Guid RecordId { get; init; }
        public string UserName { get; set; }
    }
}
