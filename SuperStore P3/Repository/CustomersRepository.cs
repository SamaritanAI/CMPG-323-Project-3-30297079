using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class CustomersRepository
    {
        protected readonly SuperStoreContext _context = new SuperStoreContext();

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }
    }
}
