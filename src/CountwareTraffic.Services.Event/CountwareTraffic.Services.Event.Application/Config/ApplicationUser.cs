﻿using Mhd.Framework.Ioc;
using System;

namespace CountwareTraffic.Services.Events.Application
{
    public class ApplicationUser : IConfigurationOptions
    {
        public Guid Id { get; set; }
    }
}
