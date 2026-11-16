using System.ComponentModel.DataAnnotations;

namespace MaSV_MyStore.Models.ViewModel
{
    public class CheckoutVM
    {
        [Required]
        [Display(Name = "Địa chỉ giao hàng")]
        public string ShippingAddress { get; set; }

        [Required]
        [Display(Name = "Phương thức giao hàng")]
        public string DeliveryMethod { get; set; }

        [Required]
        [Display(Name = "Phương thức thanh toán")]
        public string PaymentMethod { get; set; }

        public decimal TotalAmount { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
