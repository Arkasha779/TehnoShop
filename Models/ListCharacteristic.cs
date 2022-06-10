#nullable disable

namespace TehnoShop.Models
{
    public partial class ListCharacteristic
    {
        public int Id { get; set; }
        public int Characteristic { get; set; }
        public int Product { get; set; }
        public string Text { get; set; }

        public virtual Characteristic CharacteristicNavigation { get; set; }
        public virtual Product ProductNavigation { get; set; }
    }
}
