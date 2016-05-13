using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReyBusiness.Web.Models
{
    public class Phone
    {
        public int PhoneId { get; set; }
        public string PhoneNumber { get; set; }
        public PhoneType PhoneType { get; set; }
        public virtual Partner Partner { get; set; }
        public int PartnerId { get; set; }
    }

    public enum PhoneType
    {
        Private,
        BusinessDirect,
        BusinessGeneral
    }
}