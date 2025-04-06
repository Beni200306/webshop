using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webshop.Models
{
    public class Order
    {
        public Order()
        {
            
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public virtual User user { get; set; }
        public virtual Product product{ get; set; }
    }
}
