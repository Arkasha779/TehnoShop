using System.Collections.Generic;

#nullable disable

namespace TehnoShop.Models
{
    public partial class Characteristic
    {
        public Characteristic()
        {
            ListCharacteristics = new HashSet<ListCharacteristic>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }

        public virtual TypeProduct TypeNavigation { get; set; }
        public virtual ICollection<ListCharacteristic> ListCharacteristics { get; set; }
    }
}
