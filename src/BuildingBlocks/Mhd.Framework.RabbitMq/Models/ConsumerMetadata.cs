﻿using System;
using System.Reflection;

namespace Mhd.Framework.Queue
{
    public class ConsumerMetadata
    {
        public Type ConsumerType { get; set; }
        public MethodInfo Method { get; set; }
        public Type MessageType { get; set; }
        public bool IsEvent { get; set; }
    }
}
