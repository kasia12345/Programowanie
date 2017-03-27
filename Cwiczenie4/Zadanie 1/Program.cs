using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//obserwacje: gdy jeden obiekt już istnieje, użytkownik otrzyma tylko referencję do utworzonego już obiektu 

namespace ConsoleApplication8
{
    //sealed blokuje dziedziczenie
    public sealed class Uczelnia
    {
        private static Uczelnia uczelniaInstance = null;
        private int counter = 1;

        public static Uczelnia Instance()
        {
            if (uczelniaInstance == null)
            {
                uczelniaInstance = new Uczelnia();
            }

            return uczelniaInstance;
        }

        private Uczelnia()
        {
        }

        public void RekrutujStudentow()
        {
            Random rand = new Random();
            int _rok = rand.Next(2017, 2018);
            int _miesiac = rand.Next(1, 12);
            int _dzien = rand.Next(1, 31);

            Console.WriteLine("Data rekrutacji na Uniwersytecie nr {0}: ",counter++);
            Console.WriteLine(_rok + "." + _miesiac + "." + _dzien);     
        }


    static void Main(string[] args)
    {
        Uczelnia UWM = Uczelnia.Instance();
        UWM.RekrutujStudentow();

        Uczelnia Stanford = Uczelnia.Instance();
        Stanford.RekrutujStudentow();
        Console.ReadKey();
    }
  }
}