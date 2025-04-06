using webshop.Models;

namespace webshop.Data
{
    public class ProductRepository : IRepository<Product>
    {
        WebshopDB db;
        public ProductRepository(WebshopDB db)
        {
            this.db = db;
        }
        public void Create(Product entity)
        {
            db.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> Filter(Predicate<Product> condition)
        {
            return Read().Where(x=>condition(x));

        }

        public IEnumerable<Product> Read()
        {
            return db.Products;
        }

        public Product Read(int id)
        {
            throw new NotImplementedException();
        }
    }
}
