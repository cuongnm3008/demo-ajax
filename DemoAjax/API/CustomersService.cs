using DemoAjax.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAjax.API
{
    [Route("api/customers")]
    [ApiController]
    public class CustomersService : ControllerBase
    {
        Customer customers = new Customer();
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(customers.GetCustomers());
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            customers.GetCustomers().Add(customer);
            return Ok();
        }


        // GET api/<CustomersService>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomersService>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CustomersService>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomersService>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
