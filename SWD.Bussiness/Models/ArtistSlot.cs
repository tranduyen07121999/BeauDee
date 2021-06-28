using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SWD.Bussiness.Models
{
    public partial class ArtistSlot
    {
        public int ArtistSlotId { get; set; }
        public int? ArtistId { get; set; }
        public int? BookingId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public double? MinPrice { get; set; }
        public DateTime? Validate { get; set; }
        public string AreaId { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual Booking Booking { get; set; }
    }
}
