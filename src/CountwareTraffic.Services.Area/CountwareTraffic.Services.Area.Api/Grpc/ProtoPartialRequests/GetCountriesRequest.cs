﻿using Mhd.Framework.Core;
using System;

namespace CountwareTraffic.Services.Areas.Grpc
{
    [ServiceLog]
    public sealed partial class GetCountriesRequest : RequestValidate
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


        internal PagingRequest _PagingRequest
        {
            get
            {
                if (this.pagingRequest_ == null)
                {
                    this.pagingRequest_ = new PagingRequest() { Limit = 10, Page = 1 };

                    return this.pagingRequest_;
                }

                if (this.pagingRequest_.Limit < 1)
                    this.pagingRequest_.Limit = 10;

                if (this.pagingRequest_.Page < 1)
                    this.pagingRequest_.Page = 1;

                return pagingRequest_;
            }
            set { this.pagingRequest_ = value; }
        }

        public override void Validate()
        {
            if (_CompanyId == Guid.Empty)
                ValidateResults.Add(new ErrorResult($"CompanyId cannot be null", nameof(_CompanyId)));
        }
    }
}

