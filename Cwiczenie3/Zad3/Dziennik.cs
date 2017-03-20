using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/****************************************************************************/
//Programu niestety nie udało mi się napisać do końca.
/****************************************************************************/
namespace Dziennik
{
    public class Dziennik
    {
        private string _imieUcznia;
        private string _nazwiskoUcznia;
        private string _data;
        private string _przedmiot;
        private Boolean _obecnosc;
        private double ocena;

        public Dziennik(string imieUcznia, string nazwiskoUcznia)
        {
            this._imieUcznia = imieUcznia;
            this._nazwiskoUcznia = nazwiskoUcznia;
        }
        public Dziennik(string przedmiot)
        {
            this._przedmiot = przedmiot;
        }

        public Dziennik(string imieUcznia, string nazwiskoUcznia, string przedmiot, double ocenaPrzedmiotu)
        {
            this._imieUcznia = imieUcznia;
            this._nazwiskoUcznia = nazwiskoUcznia;
            this._przedmiot = przedmiot;
            this.ocena = ocenaPrzedmiotu;
        }

        public double sprawdzOcene(string imieUcznia, string nazwiskoUcznia, string przedmiot)
        {
            if(this._imieUcznia == imieUcznia && this._nazwiskoUcznia == nazwiskoUcznia && this._przedmiot == przedmiot)
            {
                double ocena = generujOcene();
            }
            return ocena;
        }

        public Boolean sprawdzObecnosc(string imieUcznia, string nazwiskoUcznia, string data)
        {
            return true;
        }

        public void dodajPrzedmiot()
        { }

        public double sredniaOcen(List<Dziennik>lista)
        {
            double ocena = generujOcene();
            double suma = 0;
            foreach(var ob in lista)
            {
                suma += ob.ocena;
            }
            return suma / lista.Count();
        }

        private double generujOcene()
        {
            double ocena;
            Random r = new Random();
            ocena = r.Next(1, 5);
            return ocena;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Dziennik> listaUczniow = new List<Dziennik>();
            listaUczniow.Add(new Dziennik("Anna", "Kowalska"));
            listaUczniow.Add(new Dziennik("Jan", "Nowak"));

            List<Dziennik> przedmioty = new List<Dziennik>();
            przedmioty.Add(new Dziennik("Bilogia"));
            przedmioty.Add(new Dziennik("Chemia"));
            przedmioty.Add(new Dziennik("Matematyka"));

            Console.ReadKey();
        }
    }
}
