using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace ShoppingCart.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetAllProducts(string productName)
        {
            return View();
        }
    }
 
  
    
}
