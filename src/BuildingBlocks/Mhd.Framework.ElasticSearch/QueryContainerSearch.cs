﻿using Nest;
using Mhd.Framework.Common;

namespace Mhd.Framework.ElasticSearch
{
    public class QueryContainerSearch
    {
        public QueryContainer QueryContainer { get; set; }
        public string SortField { get; set; }
        public SortOrder Direction { get; set; }
        public int From { get; set; } = ElasticsearchKeys.From;
        public int Size { get; set; } = ElasticsearchKeys.DefaultSize;
        public bool IsAllData { get; set; }
    }
}
