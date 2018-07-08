﻿using System;
using System.Collections.Generic;

namespace AdventureWorks.Core.Model.Purchasing
{
    public partial class ShipMethod
    {
        public ShipMethod()
        {
            PurchaseOrderHeader = new HashSet<PurchaseOrderHeader>();
        }

        public int ShipMethodId { get; set; }
        public string Name { get; set; }
        public decimal ShipBase { get; set; }
        public decimal ShipRate { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ICollection<PurchaseOrderHeader> PurchaseOrderHeader { get; set; }
    }
}