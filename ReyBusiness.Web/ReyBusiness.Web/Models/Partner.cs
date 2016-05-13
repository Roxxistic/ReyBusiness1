using System.Collections.Generic;

namespace ReyBusiness.Web.Models
{
    public class Partner
    {
        public int PartnerId { get; set; }
        public string Name { get; set; }
        public virtual IList<Address> Addresses { get; set; }
    }
}