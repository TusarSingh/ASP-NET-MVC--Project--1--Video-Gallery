using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Vidly.Models;
using Vidly.Dtos;
using AutoMapper;

namespace Vidly.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private DBCS _context;

        public CustomersController()
        {
            _context = new DBCS();
        }


        // //GET / api/customers
        //public IEnumerable<Customer> GetCustomers()
        //{

        //    return _context.Customers.ToList();
        //}


        //// GET /api/customers/1
        //public Customer GetCustomer(int id)
        //{
        //    var customer = _context.Customers.SingleOrDefault(c => c.ID == id);

        //    if (customer == null)
        //        throw new HttpResponseException(HttpStatusCode.NotFound);

        //    return customer;

        //}


        //// POST / api/customers
        //[HttpPost]
        //public Customer CreateCustomer(Customer customer)
        //{
        //    if (!ModelState.IsValid)
        //        throw new HttpResponseException(HttpStatusCode.BadRequest);

        //    _context.Customers.Add(customer);
        //    _context.SaveChanges();

        //    return customer;

        //}


        ////PUT / api/customers/1
        //[HttpPost]
        //public void UpdateCustomer(int id,Customer customer)
        //{
        //    if (!ModelState.IsValid)
        //        throw new HttpResponseException(HttpStatusCode.BadRequest);

        //    var customerInDb = _context.Customers.SingleOrDefault(c => c.ID == id);

        //    if (customerInDb == null)
        //        throw new HttpResponseException(HttpStatusCode.NotFound);

        //    customerInDb.Name = customer.Name;
        //    customerInDb.BirthDate = customer.BirthDate;
        //    customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
        //    customerInDb.MembershipTypeId = customer.MembershipTypeId;

        //    _context.SaveChanges();

        //}


        //// DELETE / api/customers/1
        //[HttpDelete]
        //public void DeleteCustomer(int id)
        //{
        //    var customerInDb = _context.Customers.SingleOrDefault(c => c.ID == id);

        //    if (customerInDb == null)
        //        throw new HttpResponseException(HttpStatusCode.NotFound);

        //    _context.Customers.Remove(customerInDb);


        //}










        ////GET / api/customers
        //public IEnumerable<CustomerDto> GetCustomers()
        //{

        //    return _context.Customers.ToList().Select(Mapper.Map<Customer, CustomerDto>);
        //}


        //// GET /api/customers/1
        //public CustomerDto GetCustomer(int id)
        //{
        //    var customer = _context.Customers.SingleOrDefault(c => c.ID == id);

        //    if (customer == null)
        //        throw new HttpResponseException(HttpStatusCode.NotFound);

        //    return Mapper.Map<Customer,CustomerDto>(customer);

        //}

        //// POST / api/customers
        //[HttpPost]
        //public CustomerDto CreateCustomer(CustomerDto customerDto)
        //{
        //    if (!ModelState.IsValid)
        //        throw new HttpResponseException(HttpStatusCode.BadRequest);

        //    var customer = Mapper.Map<CustomerDto, Customer>(customerDto);

        //    _context.Customers.Add(customer);
        //    _context.SaveChanges();

        //    customerDto.ID = customer.ID;

        //    return customerDto;

        //}


        ////PUT / api/customers/1
        //[HttpPost]
        //public void UpdateCustomer(int id, CustomerDto customerDto)
        //{
        //    if (!ModelState.IsValid)
        //        throw new HttpResponseException(HttpStatusCode.BadRequest);

        //    var customerInDb = _context.Customers.SingleOrDefault(c => c.ID == id);

        //    if (customerInDb == null)
        //        throw new HttpResponseException(HttpStatusCode.NotFound);

        //    Mapper.Map(customerDto,customerInDb);

        //    _context.SaveChanges();

        //}



        //// DELETE / api/customers/1
        //[HttpDelete]
        //public void DeleteCustomer(int id)
        //{
        //    var customerInDb = _context.Customers.SingleOrDefault(c => c.ID == id);

        //    if (customerInDb == null)
        //        throw new HttpResponseException(HttpStatusCode.NotFound);

        //    _context.Customers.Remove(customerInDb);


        //}










        // GET /api/customers
        public IEnumerable<CustomerDto> GetCustomers()
        {
            return _context.Customers.ToList().Select(Mapper.Map<Customer, CustomerDto>);
        }

        // GET /api/customers/1
        public IHttpActionResult GetCustomer(int Id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.ID == Id);

            if (customer == null)
            {
                //throw new HttpResponseException(HttpStatusCode.NotFound);

                return BadRequest();
            }

            return Ok(Mapper.Map<Customer, CustomerDto>(customer));
        }



        // POST /api/customers
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
            {
                //throw new HttpResponseException(HttpStatusCode.BadRequest);

                return BadRequest();
            }

            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);

            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDto.ID = customer.ID;

            return Created(new Uri(Request.RequestUri + "/" + customer.ID), customerDto);


        }



        // PUT /api/customers/1
        public void UpdateCustomer(int Id, CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var customerInDb = _context.Customers.SingleOrDefault(c => c.ID == Id);

            if (customerInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            Mapper.Map(customerDto, customerInDb);

            //customerInDb.Name = customer.Name;
            //customerInDb.BirthDate = customer.BirthDate;
            //customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            //customerInDb.MembershipTypeId = customer.MembershipTypeId;


            _context.SaveChanges();




        }



        // DELETE /api/customers/1
        [HttpPost]
        public void DeleteCustomer(int Id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.ID == Id);

            if (customerInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            _context.Customers.Remove(customerInDb);

            _context.SaveChanges();


        }


    }
}
