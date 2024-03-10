namespace Project_Travel.Areas.Client.Models
{
    public class CartDTO
    {
        /// <summary>
        /// Username đặt hàng
        /// </summary>
        public string? Username { get; set; }

        /// <summary>
        /// Tổng tiền
        /// </summary>
        public int TotalPrice { get; set; }

        /// <summary>
        /// Thanh toán
        /// </summary>
        public int TotalPay { get; set; }


        public ICollection<CartDetailDTO> CartDetails { get; set; } = new List<CartDetailDTO>();
    }

    public class CartDetailDTO
    {
        /// <summary>
        /// Mã sản phẩm
        /// </summary>
        public string? ProductId { get; set; }

        /// <summary>
        /// Tên sản phẩm
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Đơn giá
        /// </summary>
        public int Price { get; set; }
    }
}
