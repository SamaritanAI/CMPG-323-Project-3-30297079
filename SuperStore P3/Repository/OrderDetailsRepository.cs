using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class OrderDetailsRepository
    {
        protected readonly SuperStoreContext _context = new SuperStoreContext();

        public IEnumerable<OrderDetail> GetAll()
        {
            return _context.OrderDetails.ToList();
        }
    }
}
