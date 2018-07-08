using System;
using System.Collections.Generic;

namespace AdventureWorks.Core.Model.Sales
{
    public partial class PersonCreditCard
    {
        public int BusinessEntityId { get; set; }
        public int CreditCardId { get; set; }
        public DateTime ModifiedDate { get; set; }

        public CreditCard CreditCard { get; set; }
    }
}
