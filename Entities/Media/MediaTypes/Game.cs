using reviewPlataformConsole.Entities.Media.MediaTypes.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewPlataformConsole.Entities.Media.MediaTypes
{
    internal class Game
    {
        public MediaType type { get; set; } = MediaType.Game;
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<string> Platforms { get; set; }
        public string Genre { get; set; }
        public string AgeRating { get; set; }
        public string Trailer { get; set; }
    }
}
