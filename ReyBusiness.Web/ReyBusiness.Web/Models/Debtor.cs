using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReyBusiness.Web.Models
{
    public class Debtor
    {
        public int DebtorId { get; set; }
        public virtual Partner Partner { get; set; }
        public int PartnerId { get; set; }
        public virtual IList<Invoice> Invoices { get; set; }
    }
}