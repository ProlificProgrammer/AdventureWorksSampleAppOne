﻿using System;
using System.Collections.Generic;

namespace AdventureWorks.Core.Model.HumanResources
{
    public partial class EmployeePayHistory
    {
        public int BusinessEntityId { get; set; }
        public DateTime RateChangeDate { get; set; }
        public decimal Rate { get; set; }
        public byte PayFrequency { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Employee BusinessEntity { get; set; }
    }
}
