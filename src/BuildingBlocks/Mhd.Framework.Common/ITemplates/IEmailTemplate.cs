﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mhd.Framework.Common
{
    public interface IEmailTemplate
    {
        public string TemplateName { get; }
        public List<Guid> UserIds { get; set; }
    }
}
