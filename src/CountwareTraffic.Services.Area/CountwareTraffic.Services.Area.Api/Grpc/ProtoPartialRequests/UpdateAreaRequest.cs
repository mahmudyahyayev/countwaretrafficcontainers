﻿using Mhd.Framework.Core;
using System;

namespace CountwareTraffic.Services.Areas.Grpc
{
    [ServiceLog]
    public sealed partial class UpdateAreaRequest : RequestValidate
    {
        internal Guid _AreaId
        {
            get
            {
                if (Guid.TryParse(areaId_, out Guid id))
                    return id;

                return Guid.Empty;
            }
            set { this.areaId_ = value.ToString(); }
        }

        public override void Validate()
        {
            if (_AreaId == Guid.Empty)
                ValidateResults.Add(new ErrorResult($"AreaId cannot be null", nameof(_AreaId)));

            if (String.IsNullOrEmpty(this.Name))
                ValidateResults.Add(new ErrorResult($"Name Value cannot be null", nameof(Name)));
        }
    }
}
