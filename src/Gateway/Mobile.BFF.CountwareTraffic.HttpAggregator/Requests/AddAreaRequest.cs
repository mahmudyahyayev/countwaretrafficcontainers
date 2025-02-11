﻿using Mhd.Framework.Core;
using System;
using Mhd.Framework.Common;

namespace Mobile.BFF.CountwareTraffic.HttpAggregator
{
    public class AddAreaRequest : RequestValidate
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string GsmNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneNumber2 { get; set; }
        public string EmailAddress { get; set; }
        public string FaxNumber { get; set; }
        public string Street { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int AreaTypeId { get; set; }

        public override void Validate()
        {
            if (Name.IsNullOrWhiteSpace())
                ValidateResults.Add(new ErrorResult($"Value cannot be null", nameof(Name)));
        }
    }
}
