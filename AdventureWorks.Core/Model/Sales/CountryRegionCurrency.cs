using System;
using System.Collections.Generic;

namespace AdventureWorks.Core.Model.Sales
{
    public partial class CountryRegionCurrency
    {
        public string CountryRegionCode { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Currency CurrencyCodeNavigation { get; set; }
    }
}
