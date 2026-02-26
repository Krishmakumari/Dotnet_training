using Microsoft.AspNetCore.Mvc;
using MVC_Core_CartDemo.Models;

namespace MVC_Core_CartDemo.Controllers
{
    public class ProductController : Controller
    {
        List<Product> prodList = new List<Product>
        {
            new Product{ProdId=1,Name="Shoulder Bag",Price=4500, ImgUrl="/Images/handbag.jpg" },
            new Product{ProdId=2,Name="Mochi Metal Logo Shoulder Bag",Price=6500, ImgUrl="/Images/handbag2.jpg" },
            new Product{ProdId=3,Name="HaveGlam Embroidered Canvas Tote Bag",Price=2500, ImgUrl="/Images/handbag3.jpg" },
            new Product{ProdId=4,Name="Rare Beauty",Price=8500, ImgUrl="/Images/lipstick.jpg" },
            new Product{ProdId=5,Name="MAC lipstick",Price=499, ImgUrl="/Images/lipstick2.jpg" },
            new Product{ProdId=6,Name="Elf eyeliner",Price=399, ImgUrl="/Images/eyeliner.jpg" },
        };

        //becoz without static Every time you click a button → a NEW controller object is created →
        //cart becomes empty again.
        
        static List<Product> cart = new List<Product>();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowAllProduct()
        {
            return View(prodList);
        }

        public IActionResult AddtoCart(int id)
        {
            for(int i=0;i<prodList.Count;i++)
            {
                if (prodList[i].ProdId==id)
                {
                    cart.Add(prodList[i]);
                    break;
                }
            }
            return RedirectToAction("ShowAllProduct");
        }

        public IActionResult Cart()
        {
            return View(cart);
        }
    }
}
