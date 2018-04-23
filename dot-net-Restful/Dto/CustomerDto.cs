
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dot_net_Restful.Dto
{
    public class CustomerDto
    {[Required]
        public int id { get; set; }
    [Required]

        public string Name { get; set; }
        public bool IsSubscribe { get; set; }
       
       
        public byte MembershipTypeId { get; set; }
        public string MemberType { get; set; }
    }
}