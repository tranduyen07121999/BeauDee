using Reso.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SWD.Bussiness.ViewModels
{
    public class ArtistViewModel
    {
        public int? ArtistId { get; set; }
        [String]
        public string ArtistName { get; set; }
        [String]
        public string ArtistAddress { get; set; }
        [String]
        public string ArtistExperience { get; set; }
        [String]
        public string ArtistEducation { get; set; }
        [String]
        public string ArtistMail { get; set; }
    }
}
