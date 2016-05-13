using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReyBusiness.Web.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string Zip { get; set; }
        public string Place { get; set; }
        public virtual Partner Partner { get; set; }
        public int PartnerId { get; set; }
        public bool IsPostalAddress { get; set; }
        public bool IsInvoiceAddress { get; set; }
    }
}