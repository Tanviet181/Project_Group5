namespace Project_Travel.Areas.Client.Models
{
    public class PageCustomer
    {
      
        public required List<Product> ListProduct { get; set; }
        public required List<Brand> ListBrand { get; set; }
        public required List<CartDetailDTO> CartDetail { get; set; }
    }
}


