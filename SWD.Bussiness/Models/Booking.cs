using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SWD.Bussiness.Models
{
    public partial class Booking
    {
        public Booking()
        {
            ArtistSlot = new HashSet<ArtistSlot>();
            BookingDetail = new HashSet<BookingDetail>();
        }

        public int BookingId { get; set; }
        public int? CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<ArtistSlot> ArtistSlot { get; set; }
        public virtual ICollection<BookingDetail> BookingDetail { get; set; }
    }
}
