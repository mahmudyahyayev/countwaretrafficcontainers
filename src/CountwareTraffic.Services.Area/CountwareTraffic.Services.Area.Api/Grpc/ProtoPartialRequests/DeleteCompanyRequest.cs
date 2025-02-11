﻿using Mhd.Framework.Core;
using System;

namespace CountwareTraffic.Services.Areas.Grpc
{
    [ServiceLog]
    public sealed partial class DeleteCompanyRequest : RequestValidate
    {
        internal Guid _CompanyId
        {
            get
            {
                if (Guid.TryParse(companyId_, out Guid id))
                    return id;

                return Guid.Empty;
            }
            set { this.companyId_ = value.ToString(); }
        }

        public override void Validate()
        {
            if (_CompanyId == Guid.Empty)
                ValidateResults.Add(new ErrorResult($"CompanyId cannot be null", nameof(_CompanyId)));
        }
    }
}
