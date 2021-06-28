using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SWD.Bussiness.Models
{
    public partial class Artist
    {
        public Artist()
        {
            ArtistService = new HashSet<ArtistService>();
            ArtistSlot = new HashSet<ArtistSlot>();
        }

        public int ArtistId { get; set; }
        public string ArtistName { get; set; }
        public string ArtistAddress { get; set; }
        public string ArtistExperience { get; set; }
        public string ArtistEducation { get; set; }
        public string ArtistMail { get; set; }

        public virtual ICollection<ArtistService> ArtistService { get; set; }
        public virtual ICollection<ArtistSlot> ArtistSlot { get; set; }
    }
}
