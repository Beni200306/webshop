using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webshop.Models
{
    public class User : IUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public IEnumerable<Order> Orders { get; set; }

        public bool EighteenOver()
        {
           return Age>=18;
        }

        public string NameReturn()
        {
            throw new NotImplementedException();
        }
    }
}
