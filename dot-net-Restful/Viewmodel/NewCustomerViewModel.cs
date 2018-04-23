using dot_net_Restful.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dot_net_Restful.Viewmodel
{
    public class NewCustomerViewModel
    {
        public IEnumerable<Membershiptype> MembershipType { get; set; }
        public Customer Customer { get; set; }
    }
}