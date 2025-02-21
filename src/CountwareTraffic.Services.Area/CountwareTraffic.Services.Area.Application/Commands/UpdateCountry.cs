﻿using Convey.CQRS.Commands;
using System;

namespace CountwareTraffic.Services.Areas.Application
{
    [Contract]
    public class UpdateCountry : ICommand
    {
        public string Iso { get; set; }
        public string Iso3 { get; set; }
        public int IsoNumeric { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
        public string ContinentCode { get; set; }
        public string CurrencyCode { get; set; }
        public Guid CountryId { get; set; }
    }
}
