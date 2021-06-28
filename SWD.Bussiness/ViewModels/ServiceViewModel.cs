using Reso.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SWD.Bussiness.ViewModels
{
    public class ServiceViewModel
    {
        public int? ServiceId { get; set; }
        [String]
        public string ServiceName { get; set; }
    }
}
