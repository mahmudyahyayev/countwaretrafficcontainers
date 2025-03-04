﻿using Mhd.Framework.Core;
using System;

namespace CountwareTraffic.Services.Areas.Grpc
{
    [ServiceLog]
    public sealed partial class UpdateDistrictRequest : RequestValidate
    {
        internal Guid _DistrictId
        {
            get
            {
                if (Guid.TryParse(districtId_, out Guid id))
                    return id;

                return Guid.Empty;
            }
            set { this.districtId_ = value.ToString(); }
        }

        public override void Validate()
        {
            if (_DistrictId == Guid.Empty)
                ValidateResults.Add(new ErrorResult($"DistrictId cannot be null", nameof(_DistrictId)));

            if (String.IsNullOrEmpty(this.Name))
                ValidateResults.Add(new ErrorResult($"Name Value cannot be null", nameof(Name)));
        }
    }
}