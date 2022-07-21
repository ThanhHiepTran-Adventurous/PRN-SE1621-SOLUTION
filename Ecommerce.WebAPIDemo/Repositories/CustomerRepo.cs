using Ecommerce.WebAPIDemo.Models;
using Microsoft.AspNetCore.Mvc;
namespace Ecommerce.WebAPIDemo.Repositories
{
    public class CustomerRepo : ICustomerRepo
    {
        private FptEduStoreContext _db;
        public CustomerRepo()
        {
            this._db = new FptEduStoreContext();
        }
        public CustomerRepo(FptEduStoreContext db)
        {
            _db = db;
        }

        public ActionResult<IEnumerable<Customer>> GetAllCustomers()
        {
            return _db.Customers.ToArray();
        }
    }
}
