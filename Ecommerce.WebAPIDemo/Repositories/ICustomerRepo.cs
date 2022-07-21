using Ecommerce.WebAPIDemo.Models;
using Microsoft.AspNetCore.Mvc;
namespace Ecommerce.WebAPIDemo.Repositories
{
    public interface ICustomerRepo
    {
        public ActionResult<IEnumerable<Customer>> GetAllCustomers();
    }
}
