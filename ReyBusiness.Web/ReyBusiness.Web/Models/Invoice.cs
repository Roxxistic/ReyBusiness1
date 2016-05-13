using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReyBusiness.Web.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public virtual Debtor Debtor { get; set; }
        public int DebtorId { get; set; }
        public virtual IList<InvoiceItem> InvoiceItems { get; set; }
        public bool IsPaied { get; set; }
    }

    public class InvoiceItem
    {
        public int InvoiceItemId { get; set; }
        public virtual Invoice Invoice { get; set; }
        public int InvoiceId { get; set; }
        public string Description { get; set; }
        public float Amount { get; set; }
    }
}