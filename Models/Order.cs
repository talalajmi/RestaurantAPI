using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantAPI.Models
{
    public class Order
    {
        [Key]
        public long OrderId { get; set; }
        [Column(TypeName = "nvarchar(75)")]
        public string OrderNumber { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal OrderPrice { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public Customer Customer { get; set; }
        public virtual List<OrderDetail> GetOrderDetailsList { get; set; }
    }
}
