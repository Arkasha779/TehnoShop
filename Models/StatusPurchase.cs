using System.Collections.Generic;

#nullable disable

namespace TehnoShop.Models
{
    public partial class StatusPurchase
    {
        public StatusPurchase()
        {
            Purchases = new HashSet<Purchase>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
