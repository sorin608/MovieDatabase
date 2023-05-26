using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Filme
{
    internal class Film
    {
       public string titlu { get; private set; }
       public uint an { get; private set; }
       public string director { get; private set; }
       private string rating;
       private double nota;
       public List<Film> filme = new List<Film>();
       public static int contor;
             
        public Film(string titlu, uint an, string director, string rating, double nota)
        {
            this.titlu = titlu;
            this.an = an;
            this.director = director;
            Rating = rating;
            Nota = nota;                  
        }

        public string Rating
        {
            get { return rating; }
            set {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                    rating = value;
                else
                    rating = "NR";
            }
        }

        public double Nota
        {
            get { return nota; }
            set {
                if (value > 0)
                    nota = value;
                else
                    nota = 0;
            }
        }

        public Film()
        {
            Film m1 = new Film("Top Gun:Maverick", 2022, "Joseph Kosinski", "PG-13", 8.3);
            filme.Add(m1);
            Film m2 = new Film("Sherlock Holmes", 2009, "Guy Ritchie", "PG-13", 7.6);
            filme.Add(m2);
            Film m3 = new Film("Pirates of the Caribbean", 2003, "Gore Verbinski", "PG-13", 8.1);
            filme.Add(m3);
            Film m4 = new Film("Law Abiding Citizen", 2009, "F. Gary Gray", "R", 7.4);
            filme.Add(m4);          
            contor = filme.Count;
        }

        public override string ToString()
        {
            return $"{titlu} {an} {director} {rating} {nota}";           
        }

        public void afisare()
        {
            foreach(var m in filme)
                Console.WriteLine(m.ToString());
        }

        public void AdaugareConsola()
        {
            Console.WriteLine("1--Film  2--Film Horror");
            int x = int.Parse(Console.ReadLine());
            if (x == 1) {
                Film m = new Film();
                Console.Write("Titlu: ");
                m.titlu = Console.ReadLine();
                Console.Write("An: ");
                m.an = uint.Parse(Console.ReadLine());
                Console.Write("Director: ");
                m.director = Console.ReadLine();
                Console.Write("Rating: ");
                m.Rating = Console.ReadLine();
                Console.Write("Nota: ");
                m.Nota = double.Parse(Console.ReadLine());
                filme.Add(m);
                contor = filme.Count;
            }
            else {
                FilmHorror n = new FilmHorror();
                Console.Write("Titlu: ");
                n.titlu = Console.ReadLine();
                Console.Write("An: ");
                n.an = uint.Parse(Console.ReadLine());
                Console.Write("Director: ");
                n.director = Console.ReadLine();
                Console.Write("Rating: ");
                n.Rating = Console.ReadLine();
                Console.Write("Nota: ");
                n.Nota = double.Parse(Console.ReadLine());
                Console.Write("HorrorMetru: ");
                n.hrrMeter = Console.ReadLine();
                filme.Add(n);
                contor = filme.Count;
            }
        }

        public void Sortare()
        {
            Console.WriteLine("Sortare: 1.Alfabetic dupa titlu  2.Descrescator dupa nota");
            int x = int.Parse(Console.ReadLine());
            if (x == 1)
                filme.Sort((x, y) => string.Compare(x.titlu, y.titlu));
            else
                filme.Sort((x, y) => y.nota.CompareTo(x.nota));

        }

        public void Salvare()
        {
            string jsonString = JsonConvert.SerializeObject(filme);
            File.WriteAllText("filme.txt", jsonString);
            Console.WriteLine("Lista a fost salvata in fisierul filme.txt");

        }
    }  
        
   
}

