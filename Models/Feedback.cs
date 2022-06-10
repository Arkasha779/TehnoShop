using System;

#nullable disable

namespace TehnoShop.Models
{
    public partial class Feedback
    {
        public int Id { get; set; }
        public string Advantages { get; set; }
        public string Disadvantages { get; set; }
        public string Other { get; set; }
        public int? Author { get; set; }
        public DateTime Date { get; set; }
        public int Rate { get; set; }
        public int Product { get; set; }

        public virtual User AuthorNavigation { get; set; }
        public virtual Product ProductNavigation { get; set; }
    }
}
