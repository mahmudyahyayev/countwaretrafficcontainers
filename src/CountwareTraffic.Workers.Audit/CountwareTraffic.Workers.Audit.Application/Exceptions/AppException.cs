﻿using Mhd.Framework.Core;
using System.Collections.Generic;

namespace CountwareTraffic.Workers.Audit.Application
{
    public abstract class AppException : BaseException
    {
        public AppException(ICollection<ErrorResult> errorResults, int statusCode, ResponseMessageType responseMessageType)
            : base(errorResults, statusCode, responseMessageType) { }
    }
}
