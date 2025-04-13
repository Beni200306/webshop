
namespace webshop.Models
{
    public interface ICart
    {
        List<Product> Products { get; set; }
        User User { get; set; }

        void Add(Product prod);
    }
}