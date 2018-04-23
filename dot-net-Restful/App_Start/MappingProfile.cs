using AutoMapper;
using dot_net_Restful.Dto;
using dot_net_Restful.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dot_net_Restful.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>();
          
           


            // Dto to Domain
           CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.id, opt => opt.Ignore());

           

        }
    }
}