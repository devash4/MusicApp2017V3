using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApp2017.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        [Required(ErrorMessage ="Title is required")]
        public string Title { get; set; }

        // FK
        public int ArtistID { get; set; }

        public Artist Artist { get; set; }
  
        [Display(Name ="Genre")]
        public int GenreID { get; set; }
 
        public Genre Genre { get; set; }

    }
}
