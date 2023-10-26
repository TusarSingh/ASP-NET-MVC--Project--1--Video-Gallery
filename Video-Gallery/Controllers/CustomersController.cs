using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Vidly.Models;
using System.Data.Entity;
using System.Web;
using Vidly.ViewModel;


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

            return View(viewmodel);
        }


        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            return View();
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
    }
}