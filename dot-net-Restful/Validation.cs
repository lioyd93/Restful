using dot_net_Restful.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dot_net_Restful
{
    public class Validationname:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance; 
           
            return (customer.Name != null) ? ValidationResult.Success : new ValidationResult("Please Name is required");
        }
    }
}