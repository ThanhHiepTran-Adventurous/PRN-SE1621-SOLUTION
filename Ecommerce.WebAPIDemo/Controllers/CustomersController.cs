using Microsoft.AspNetCore.Mvc;
using Ecommerce.WebAPIDemo.Models;
using Ecommerce.WebAPIDemo.Repositories;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ecommerce.WebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private ICustomerRepo _customerRepo;
        public CustomersController()
        {
            _customerRepo = new CustomerRepo();
        }
        // GET: api/<CustomersController>
        [HttpGet]
        public ActionResult<IEnumerable <Customer>> Get()
        {
            return _customerRepo.GetAllCustomers();
        }
        

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
