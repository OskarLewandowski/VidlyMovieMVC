﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VidlyMovieMVC.Dtos;
using VidlyMovieMVC.Models;

namespace VidlyMovieMVC.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/customers
        [HttpGet]
        public IHttpActionResult GetCustomers()
        {
            var customers = _context.Customers.ToList().Select(Mapper.Map<Customer, CustomerDto>);
            return Ok(customers);
        }

        // GET /api/customers/id
        [HttpGet]
        public IHttpActionResult GetCustomers(int id)
        {
            var customer = _context.Customers.SingleOrDefault(x => x.Id == id);

            if (customer == null)
                return NotFound();

            return Ok(Mapper.Map<Customer, CustomerDto>(customer));
        }

        // POST /api/customers
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);

            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDto.Id = customer.Id;

            return Created(new Uri(Request.RequestUri + "/" + customer.Id.ToString()), customerDto);
        }

        // PUT /api/customers/id
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id, CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customerInDb = _context.Customers.SingleOrDefault(x => x.Id == id);

            if (customerInDb == null)
                return NotFound();

            //Mapper.Map<CustomerDto, Customer>(customerDto, customerInDb);
            Mapper.Map(customerDto, customerInDb);

            _context.SaveChanges();

            return Ok();
        }

        // DELETE /api/customers/id
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(x => x.Id == id);

            if (customerInDb == null)
                return NotFound();

            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
