using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SWD.Bussiness.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductArtistService = new HashSet<ProductArtistService>();
        }

        public int ProductId { get; set; }
        public int? ServiceId { get; set; }
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public double? ProductPrice { get; set; }

        public virtual Service Service { get; set; }
        public virtual ICollection<ProductArtistService> ProductArtistService { get; set; }
    }
}
