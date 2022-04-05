using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantAPI.Models
{
    public class Food
    {
        [Key]
        public int FoodId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string FoodName { get; set; }
        public decimal FoodPrice { get; set; }
        public int OrderDetailId { get; set; }
        [ForeignKey(nameof(OrderDetailId))]
        #nullable enable
        public OrderDetail? OrderDetail { get; set; }
    }
}
