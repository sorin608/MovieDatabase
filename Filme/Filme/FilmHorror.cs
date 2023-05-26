using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Filme
{
    internal class FilmHorror : Film
    {
        public string hrrMeter;

        public FilmHorror(string titlu, uint an, string director, string rating, double nota, string hrrMeter)
            : base(titlu, an, director, rating, nota)
        {
            this.hrrMeter = hrrMeter;
            contor++;
        }
        public FilmHorror()
        {
            var h1 = new FilmHorror("Alien", 1979, "Ridley Scott", "R", 8.5, "Very Scary");
            filme.Add(h1);
            var h2 = new FilmHorror("House of Wax", 2005, "Jaume Collet-Serra", "R", 5.4, "Scary");
            filme.Add(h2);
        }

        public override string ToString()
        {
            return base.ToString() + $" {hrrMeter}";
        }

    }
}
