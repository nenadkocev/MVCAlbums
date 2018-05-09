using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace primerKolokviumska2.Models
{
    public class AddToStore
    {
        public List<Album> Albums { get; set; }
        public int selectedAlbum { get; set; }
        public int storeId { get; set; }

        public AddToStore()
        {
            Albums = new List<Album>();
        }
    }
}