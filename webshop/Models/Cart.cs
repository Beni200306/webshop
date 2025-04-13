namespace webshop.Models
{
    public class Cart : ICart
    {
        User user;
        List<Product> products;
        public Cart()
        {
            products = new List<Product>();
        }

        public User User { get => user; set => user = value; }
        public List<Product> Products { get => products; set => products = value; }


        public void Add(Product prod)
        {
            products.Add(prod);
        }
    }
}
