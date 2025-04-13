using Microsoft.AspNetCore.Mvc;
using webshop.Data;
using webshop.Models;
namespace webshop.Controllers
{
    public class ShopController:Controller
    {
        IRepository<Product> productRepo;
        IRepository<Order> orderRepo;
        ICart cart;
        public ShopController(IRepository<Product> productRepo, ICart cart)
        {
            this.productRepo = productRepo;
            this.cart = cart;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string name, int age)
        {
            cart.User = new User() { Age = age, Name = name };
            return RedirectToAction(nameof(Main));
        }

        public IActionResult Main()
        {
            
            if (cart.User.EighteenOver())
            {
                return View(productRepo.Read());
            }
            else { return View(productRepo.Filter(x=>!x.OverEighteen));}
        }
        public IActionResult AddCart(int productId)
        {
            Product add = productRepo.Read(productId);
            cart.Add(add);
            
            return RedirectToAction(nameof(Main));
        }


    }
}
