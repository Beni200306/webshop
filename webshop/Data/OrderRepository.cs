using webshop.Models;

namespace webshop.Data
{
    public class OrderRepository : IRepository<Order>
    {
        WebshopDB db;
        public OrderRepository(WebshopDB db)
        {
            this.db = db;
        }

        public void Create(Order entity)
        {
            db.Orders.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> Filter(Predicate<Order> condition)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> Read()
        {
            return db.Orders;
        }

        public Order? Read(int id)
        {
            return db.Orders.FirstOrDefault(x=>x.ID==id);
        }
    }
}
