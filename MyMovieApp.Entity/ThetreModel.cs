using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMovieApp.Entity
{
    public class ThetreModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TheaterId { get; set; }
        public string TheaterName { get; set; }

        public string TheaterMovies { get; set; }

        public string TheaterAddress { get; set; }

    }
}
