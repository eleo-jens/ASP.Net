using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exo1_Route.Models
{
    public class Film
    {
        public string Titre { get; set; }
        public string Poster { get; set; }

        public Film(string titre, string poster)
        {
            Titre = titre;
            Poster = poster;
        }
    }
}
