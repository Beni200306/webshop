using Microsoft.AspNetCore.Mvc;
using webshop.Data;
using webshop.Models;
namespace webshop.Controllers
{
    public class ShopController:Controller
    {
        IRepository<Product> productRepo;
        IRepository<Order> orderRepo;
        IUser user;
        public ShopController(IRepository<Product> productRepo, IUser user)
        {
            this.productRepo = productRepo;
            this.user = user;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        
        public IActionResult Main(string name, int age)
        {
            if (user.EighteenOver())
            {
                return View(productRepo.Read());
            }
            else { return View(productRepo.Filter(x=>!x.OverEighteen));}
        }
        public IActionResult AddCart(int productId)
        {
            Product add = productRepo.Read(productId);
            //Order ord = new Order() { product=add, user=user };
            
            return RedirectToAction(nameof(Main));
        }


    }
}
