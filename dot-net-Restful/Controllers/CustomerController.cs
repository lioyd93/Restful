using dot_net_Restful.Models;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dot_net_Restful.Viewmodel;

namespace dot_net_Restful.Controllers
{
    public class CustomerController : Controller
    {
        private DatabaseContaxt _context;
        
        public CustomerController()
        {
            _context = new DatabaseContaxt();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult New()
        {
            var membershiptype = _context.MembershipType.ToList();
            var viewModel = new NewCustomerViewModel
            {
                MembershipType = membershiptype
            };
            return View("New",viewModel );
        }
        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            if (customer.id == 0) { _context.Customer.Add(customer); }
            else
            {
                var customerinfo = _context.Customer.Single(c => c.id == customer.id);
                customerinfo.Name = customer.Name;
                customerinfo.MemberType = customer.MemberType;
                customerinfo.IsSubscribe = customer.IsSubscribe;
            }
            _context.SaveChanges();
            return RedirectToAction("Index","Customer");
        }
        public ActionResult Edit(int id)
        {
            var customer = _context.Customer.SingleOrDefault(c => c.id == id);
            if (customer == null) { return HttpNotFound(); }
            var ViewModel=new NewCustomerViewModel { 
                Customer=customer,
                MembershipType = _context.MembershipType.ToList()
            };
           
            return View("New", ViewModel);
        }
        

    
        public ActionResult Details(int id)
        {
            var customers = _context.Customer.SingleOrDefault(c=>c.id==id);
            if (customers == null) { return HttpNotFound(); }
             return View("Details", customers); 
        }
        public ActionResult index()
        {
            var customers = _context.Customer.Include(c => c.Mebmershiptype).ToList();
            return View(customers);
        }
    }
}