using dot_net_Restful.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace dot_net_Restful.Models
{  [Table("Customer")]
    public class Customer
    {   [Key]
     
        public int id { get; set; }
        [Required]
        [Validationname]
        public string Name { get; set; }
        public bool IsSubscribe { get; set; }
        public Membershiptype Mebmershiptype { get; set; }
        [Required]
        public byte MembershipTypeId { get; set; }
        public string MemberType { get; set; }
    }
}