﻿using Mhd.Framework.Core;
using System;
using System.Collections.Generic;

namespace CountwareTraffic.Services.Areas.Core
{
    public class SubAreaNotFoundException : DomainException
    {
        public Guid SubAreaId { get; }

        public SubAreaNotFoundException(Guid id)
            : base(new List<ErrorResult>() { new ErrorResult($"SubArea with id: {id} not found.") }, 404, ResponseMessageType.Error)
        {
            SubAreaId = id;
        }
    }
}
