using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace dot_net_Restful.Models
{
    public class Membershiptype
    {[Key]
        public byte id { get; set; }
        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte durationInMonth { get; set; }
        public byte DiscountRate { get; set; }
        

    }
}