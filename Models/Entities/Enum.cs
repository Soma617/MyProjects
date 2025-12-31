using System.ComponentModel.DataAnnotations;

namespace Interview1.Models.Entities
{
    public enum OrderStatus
    {
        [Display(Name = "待確認")]
        Pending,
        [Display(Name = "已確認")]
        Confirmed,
        [Display(Name = "已出貨")]
        Shipped,
        [Display(Name = "已完成")]
        Completed,
        [Display(Name = "已取消")]
        Cancelled
    }

    public enum PaymentMethod
    {
        [Display(Name = "信用卡支付")]
        CreditCard,
        [Display(Name = "貨到付款")]
        CashOnDelivery,
        [Display(Name = "銀行轉帳")]
        BankTransfer,
        [Display(Name = "第三方支付")]
        Others
    }

    public enum ShippingStatus
    {
        [Display(Name = "待出貨")]
        Pending,
        [Display(Name = "運送中")]
        Shipping,
        [Display(Name = "已到貨")]
        Delivered
    }
}
