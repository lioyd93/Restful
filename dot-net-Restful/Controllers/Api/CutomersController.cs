using dot_net_Restful.Dto;
using dot_net_Restful.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace dot_net_Restful.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private DatabaseContaxt  _context;

        public CustomersController()
        {
            _context = new DatabaseContaxt();
        }
        //Get /Customers
        public IEnumerable<CustomerDto> GetCustomer() 
        {
            return _context.Customer.ToList().Select(AutoMapper.Mapper.Map<Customer,CustomerDto>); 
        }
        public IHttpActionResult  GetCustomer(int id)
        {
            var customer = _context.Customer.SingleOrDefault(c=>c.id==id);
            if (customer == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);

            }
            return Ok(AutoMapper.Mapper.Map<Customer, CustomerDto>(customer));

        }
        //Post/Api/cutomers
        [HttpPost]
        public IHttpActionResult createcustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var customer = AutoMapper.Mapper.Map<CustomerDto, Customer>(customerDto);
            _context.Customer.Add(customer);
            _context.SaveChanges();
            customerDto.id = customer.id;
            return Created(new Uri(Request.RequestUri+ "/" +customer.id),customerDto); 
        }
        //Put /Api
        public void UpdateCustomer(int id ,CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            var customerInDbB=_context.Customer.SingleOrDefault(c=>c.id==id);
            if (customerInDbB==null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            
            }
            AutoMapper.Mapper.Map<CustomerDto, Customer>(customerDto, customerInDbB);
           
            _context.SaveChanges();
           
        }
        //Delete//Api
        [HttpDelete]
        public void Delete(int id, Customer customer)
        {
           
            var customerInDbB = _context.Customer.SingleOrDefault(c => c.id == id);
            if (customerInDbB == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);

            }

            _context.Customer.Remove(customerInDbB);
            _context.SaveChanges();

        }
    }
}
