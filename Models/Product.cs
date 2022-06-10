using System.Collections.Generic;

#nullable disable

namespace TehnoShop.Models
{
    public partial class Product
    {
        public Product()
        {
            Carts = new HashSet<Cart>();
            Feedbacks = new HashSet<Feedback>();
            ListCharacteristics = new HashSet<ListCharacteristic>();
            Purchases = new HashSet<Purchase>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Type { get; set; }
        public int Published { get; set; }
        public int Brand { get; set; }
        public string Image { get; set; }

        public virtual Brand BrandNavigation { get; set; }
        public virtual User PublishedNavigation { get; set; }
        public virtual TypeProduct TypeNavigation { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<ListCharacteristic> ListCharacteristics { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
