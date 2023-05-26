using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace Filme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var f = new FilmHorror();           
            Console.WriteLine("BINE AI VENIT PE HOME FILMS");            
            int X = 0;
            do
            {
                Console.WriteLine();
                Console.WriteLine($"Momentan avem " + Film.contor + " filme in baza de date!");
                Console.WriteLine("1--Afisare\n2--Adauga film\n3--Sorteaza\n4--Salveaza\n5--Exit");              
                X = int.Parse(Console.ReadLine());
                if (X == 1)
                    f.afisare();
                else if (X == 2)
                    f.AdaugareConsola();
                else if (X == 3)
                    f.Sortare();
                else if (X == 4)
                    f.Salvare();
                else if (X == 5) { break; }
                else { X = 0; }
                    
            }
            while (X != 5);
            System.Environment.Exit(0);
            



            Console.ReadKey();
        }
    }
}