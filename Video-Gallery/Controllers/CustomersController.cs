using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Vidly.Models;
using System.Data.Entity;
using Vidly.ViewModel;
using AutoMapper;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {

        //private ApplicationDbContext _context;
        private DBCS _context;

        public CustomersController()
        {
            //_context = new ApplicationDbContext();
            _context = new DBCS();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();

            var viewmodel = new NewCustomerViewModel
            {
                MembershipTypes = membershipTypes
            };

            return View("CustomerForm", viewmodel);
        }



        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new NewCustomerViewModel
                {
                    Customer = customer,
                    MembershipTypes = _context.MembershipTypes.ToList()
                };
                return View("CustomerForm", viewModel);
            }

            if(customer.ID == 0)
                _context.Customers.Add(customer);
            else
            {
                var customerInDb = _context.Customers.Single(c => c.ID == customer.ID);

               // TryUpdateModel(customerInDb,"",new string[] {"Name","Email"});
                 
                //Mapper.Map(customer, customerInDb);//////

                customerInDb.Name = customer.Name;
                customerInDb.BirthOfDate = customer.BirthOfDate;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;



            }
             _context.SaveChanges();

            return RedirectToAction("Index","Customers");
        }


        // GET: Customers
        public ActionResult Index()
        {
            //var customers = GetCustomers();

            //var customers = _context.Customers.ToList();

            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            //var customer = GetCustomers().SingleOrDefault(c => c.ID == id);

            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.ID == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        //private IEnumerable<Customer> GetCustomers()
        //{
        //    return new List<Customer>
        //    {
        //        new Customer { ID = 1, Name = "John Smith"},
        //        new Customer { ID = 2, Name = "Mary Williams"},


        //    };
        //}


        public ActionResult Edit(int? Id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.ID == Id);

            if(customer == null)
            {
                return Content("Sorry");
                //return HttpNotFound();
            }

            var viewModel = new NewCustomerViewModel
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };

            return View("CustomerForm", viewModel);
        }
    }
}