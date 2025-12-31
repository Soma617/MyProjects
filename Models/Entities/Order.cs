using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Interview1.Models.Entities
{
    public class Order
    {
        [Display(Name = "訂單編號")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid OrderId { get; set; } /* 主鍵OrderID用GUID自動生成，並且資料庫要連接OrderDetails */

        [Display(Name = "訂單日期")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "訂單編號")]
        [Required]
        public string MemberId { get; set; } = null!;
        public Member Member { get; set; }

        [Display(Name = "訂單總金額")]
        [Column(TypeName = "decimal(7,2)")]
        public decimal TotalAmount { get; set; }

        [Display(Name = "訂單狀態")]
        [Required]
        public OrderStatus OrderStatus { get; set; }

        [Display(Name = "付款方式")]
        [Required]
        public PaymentMethod PaymentMethod { get; set; }

        [Display(Name = "出貨方式")]
        [Required]
        public ShippingStatus ShippingStatus { get; set; }

        [Display(Name = "備註")]
        [StringLength(40)]
        public string? Note { get; set; }
    }
}