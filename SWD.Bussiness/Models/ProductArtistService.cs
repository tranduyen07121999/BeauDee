using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SWD.Bussiness.Models
{
    public partial class ProductArtistService
    {
        public int ProductId { get; set; }
        public int ArtistServiceId { get; set; }

        public virtual ArtistService ArtistService { get; set; }
        public virtual Product Product { get; set; }
    }
}
