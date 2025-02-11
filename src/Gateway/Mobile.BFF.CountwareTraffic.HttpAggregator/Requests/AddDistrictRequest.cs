﻿using Mhd.Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mobile.BFF.CountwareTraffic.HttpAggregator
{
    public class AddDistrictRequest : RequestValidate
    {
        public string Name { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Name))
                ValidateResults.Add(new ErrorResult($"Value cannot be null", nameof(Name)));
        }
    }
}
