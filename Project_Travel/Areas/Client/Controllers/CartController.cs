using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project_Travel.Areas.Client.Models;

namespace Project_Travel.Areas.Client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : Controller
    {

        public CartController() { }

        [HttpPost("AddToCart")]
        public void AddToCart(CartDetailDTO data)
        {
         
            // tạo giỏ hàng mới
            CartDTO fullCarts = new();
            ICollection<CartDetailDTO> listCart = new List<CartDetailDTO>();
            string valueSession = HttpContext.Session.GetString("list_cart") ?? "";
            if (valueSession != "")
            {
                fullCarts = JsonConvert.DeserializeObject<CartDTO>(valueSession) ?? new();
                listCart = fullCarts.CartDetails;
                var item = listCart.Where(x => x.ProductId == data.ProductId).FirstOrDefault();
                if (item == null)
                {
                    listCart.Add(data);
                }
            }
            else
            {
                listCart.Add(data);
            }
            fullCarts.CartDetails = listCart;
            if (fullCarts.CartDetails != null)
            {
                fullCarts.TotalPay = fullCarts.CartDetails.Sum(x => x.Price);
            }
            else
            {
                fullCarts.TotalPay = 0;
                fullCarts.TotalPrice = 0;
            }
            HttpContext.Session.SetString("list_cart", JsonConvert.SerializeObject(fullCarts));
        }
    }
}
