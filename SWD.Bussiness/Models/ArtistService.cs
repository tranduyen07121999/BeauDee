using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SWD.Bussiness.Models
{
    public partial class ArtistService
    {
        public ArtistService()
        {
            ProductArtistService = new HashSet<ProductArtistService>();
        }

        public int? ServiceId { get; set; }
        public int ArtistServiceId { get; set; }
        public int? ArtistId { get; set; }
        public double? ServiceFee { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual Service Service { get; set; }
        public virtual ICollection<ProductArtistService> ProductArtistService { get; set; }
    }
}
