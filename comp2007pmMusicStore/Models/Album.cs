using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace comp2007pmMusicStore.Models
{
    public class Album
    {
        public string Title { get; set;}
        public Genre genre { get; set; }
        public string AlbumArtUrl { get; set; }
        public double Price { get; set; }
    }
}