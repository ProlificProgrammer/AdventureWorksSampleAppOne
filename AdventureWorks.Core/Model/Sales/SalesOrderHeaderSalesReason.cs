﻿using System;
using System.Collections.Generic;

namespace AdventureWorks.Core.Model.Sales
{
    public partial class SalesOrderHeaderSalesReason
    {
        public int SalesOrderId { get; set; }
        public int SalesReasonId { get; set; }
        public DateTime ModifiedDate { get; set; }

        public SalesOrderHeader SalesOrder { get; set; }
        public SalesReason SalesReason { get; set; }
    }
}
