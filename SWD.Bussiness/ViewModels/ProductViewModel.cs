using Reso.Core.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SWD.Bussiness.ViewModels
{
    public class ProductViewModel
    {
        public int? ProductId { get; set; }
        public int? ServiceId { get; set; }

        [String]
        public string ProductName { get; set; }

        [String]
        public string ProductBrand { get; set; }
        public double? ProductPrice { get; set; }
        //public ServiceViewModel Service { get; set; }

    }



}
