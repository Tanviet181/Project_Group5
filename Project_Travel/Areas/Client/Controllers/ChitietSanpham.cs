using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Project_Travel.Areas.Client.Models;

namespace Project_Travel.Areas.Client.Controllers
{
    public class ChitietSanpham : Controller
    {
        StoreContext objStoreContext = new StoreContext();

        public ChitietSanpham() { }

        /// <summary>
        /// View Book
        public IActionResult Index(int id)
        {
            var objPageCustomer = objStoreContext.Products.Where(n => n.Id == id).FirstOrDefault();
            return View(objPageCustomer);
        }

        ///View Book Transport
        public IActionResult Index1(int id)
        {
            var objPageCustomer = objStoreContext.Products.Where(n => n.Id == id).FirstOrDefault();
            return View(objPageCustomer);
        }

        [Route("cart.html")]
        public async Task<IActionResult> Cart()
        {
            var objPageCustomer = await objStoreContext.Products.ToListAsync();
            return View(objPageCustomer);
        }
    }
}
