using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SWD.Bussiness.Models
{
    public partial class Service
    {
        public Service()
        {
            ArtistService = new HashSet<ArtistService>();
            BookingDetail = new HashSet<BookingDetail>();
            CustomerService = new HashSet<CustomerService>();
            Product = new HashSet<Product>();
        }

        public int ServiceId { get; set; }
        public string ServiceName { get; set; }

        public virtual ICollection<ArtistService> ArtistService { get; set; }
        public virtual ICollection<BookingDetail> BookingDetail { get; set; }
        public virtual ICollection<CustomerService> CustomerService { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}
