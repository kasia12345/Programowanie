using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ConsoleApplication8
    {
        interface ITelefon
        {
            int WybierzNumer();
            string WyslijWiadomosc();
            string PokazTyp();

            string RodzajTelefonu { get; set; }
        }

        class ZwyklyTelefon : ITelefon
        {
            public string RodzajTelefonu { get; set; }


            public ZwyklyTelefon(string rodzajTelefonu)
            {
                this.RodzajTelefonu = rodzajTelefonu;
            }

            public string PokazTyp()
            {
                Console.WriteLine("Rdzaj telefonu: " + RodzajTelefonu);
                return RodzajTelefonu;
            }

            public int WybierzNumer()
            {
                Console.WriteLine("Wpisz numer: ");
                int numerTelefonu = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Wybrano numer: " + numerTelefonu);
                return numerTelefonu;
            }

            public string WyslijWiadomosc()
            {
                Console.WriteLine("Wpisz wiadomosc: ");
                string wiadomosc = Console.ReadLine();
                //Console.WriteLine("Wiadomosc: " + wiadomosc);
                return wiadomosc;
            }
        }

        abstract class Dekorator : ITelefon
        {
            protected ITelefon telefon;
            public string RodzajTelefonu { get; set; }

            public Dekorator(ITelefon tel)
            {
                this.telefon = tel;
            }

            public string PokazTyp()
            {
                return telefon.PokazTyp();
            }

            public int WybierzNumer()
            {
                return telefon.WybierzNumer();
            }

            public string WyslijWiadomosc()
            {
                return telefon.WyslijWiadomosc();
            }
        }

        class Smartphone : Dekorator
        {
            public Smartphone(ZwyklyTelefon zwyklyTelefon, string rodzajTelefonu) : base(zwyklyTelefon)
            {
                RodzajTelefonu = rodzajTelefonu;
            }

            public DateTime DataWyslania()
            {
                Random r = new Random();
                DateTime data = new DateTime(2017, 03, 20);
                int zakres = (DateTime.Today - data).Days;
                Console.WriteLine("Data wyslania: " + data.AddDays(r.Next(zakres)));
                return data.AddDays(r.Next(zakres));
            }

            public int rokProdukcji()
            {
                Random r = new Random();
                int rok = r.Next(2014, 2017);
                Console.WriteLine("Rok produkcji: " + rok);
                return rok;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                ZwyklyTelefon zwyklyTel = new ZwyklyTelefon("Zwykly");
                //Console.WriteLine(zwyklyTel.RodzajTelefonu);
                zwyklyTel.WybierzNumer();
                zwyklyTel.WyslijWiadomosc();
                zwyklyTel.PokazTyp();

                Smartphone smartTel = new Smartphone(zwyklyTel, "Smartphone");
                //Console.WriteLine(smartTel.RodzajTelefonu);
                smartTel.WybierzNumer();
                smartTel.WyslijWiadomosc();
                smartTel.PokazTyp();
                smartTel.DataWyslania();
                smartTel.rokProdukcji();
                Console.ReadKey();
            }
        }
    }
}