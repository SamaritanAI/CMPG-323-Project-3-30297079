using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class ProductsRepository
    {
        protected readonly SuperStoreContext _context = new SuperStoreContext();

        

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }
    }
}
