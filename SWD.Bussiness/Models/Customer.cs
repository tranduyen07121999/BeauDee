using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SWD.Bussiness.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Booking = new HashSet<Booking>();
            CustomerService = new HashSet<CustomerService>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime? CustomerBirthDay { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }

        public virtual ICollection<Booking> Booking { get; set; }
        public virtual ICollection<CustomerService> CustomerService { get; set; }
    }
}
