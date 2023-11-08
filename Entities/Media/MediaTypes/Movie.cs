using reviewPlataformConsole.Entities.Media.MediaTypes.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewPlataformConsole.Entities.Media.MediaTypes
{
    internal class Movie
    {
        public MediaType Yype { get; set; } = MediaType.Movie;
        public string Director { get; set; }
        public string Genre { get; set; }
        public DateTime Release { get; set; }
        public string AgeRating { get; set; }
        public string Synopsis { get; set; }
        public List<string> Actors { get; set; }
        public TimeOnly Duration { get; set; }
        public string Language { get; set; }
        public string ContryOrigin { get; set; }
        public string ProductionStudio { get; set; }
        public string Trailer { get; set; }
    }
}
