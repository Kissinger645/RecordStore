using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecordStore.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string AlbumTitle { get; set; }
        public DateTime Released { get; set; }
        public string TrackList { get; set; }
        public string Genre { get; set; }
        public int BandId { get; set; }

        public virtual Band Band { get; set; }
    }
}