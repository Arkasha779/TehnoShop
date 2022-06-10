#nullable disable

namespace TehnoShop.Models
{
    public partial class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Product { get; set; }

        public virtual Product ProductNavigation { get; set; }
        public virtual User User { get; set; }
    }
}
