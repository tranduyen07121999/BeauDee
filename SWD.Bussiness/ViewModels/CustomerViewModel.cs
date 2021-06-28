using Reso.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SWD.Bussiness.ViewModels
{
    public class CustomerViewModel
    {
        public int? CustomerId { get; set; }
        [String]
        public string CustomerName { get; set; }
        [String]
        public DateTime? CustomerBirthDay { get; set; }
        [String]
        public string CustomerAddress { get; set; }
        [String]
        public string CustomerPhone { get; set; }
        [String]
        public string CustomerEmail { get; set; }
    }
}
