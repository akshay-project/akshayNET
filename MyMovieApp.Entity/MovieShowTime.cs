using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MyMovieApp.Entity
{
    internal class MovieShowTime
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShowId { get; set; }
        [ForeignKey("MovieModel")]
        public int MovieId { get; set; }

        public MovieModel movieModel { get; set; }
        [ForeignKey("Theater")]
        public int TheaterId { get; set; }

        public Theater theaterModel { get; set; }

        public string ShowTime { get; set; }

        public string Date { get; set; }

    }
}
