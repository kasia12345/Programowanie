using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public enum Producent { Samsung, Apple }

    interface IProdukt
    {
        void wyprodukujEkran();
        void wyprodukujObudowe();
    }

    class Samsung : IProdukt
    {
        public void wyprodukujEkran() 
        {
            Console.WriteLine("Wyprodukowano ekran firmy Samsung");
        }

        public void wyprodukujObudowe() 
        {
            Console.WriteLine("Wyprodukowano obudowę firmy Samsung");
        }

    }

    class Apple : IProdukt
    {
        public void wyprodukujEkran() 
        {
            Console.WriteLine("Wyprodukowano ekran firmy Apple");
        }

        public void wyprodukujObudowe() 
        {
            Console.WriteLine("Wyprodukowano obudowę firmy Apple");
        }

    }

    static class ProduktFactory
    {
        public static IProdukt TworzenieObiektuTelefon(Producent rodzajProducenta)
        {
            IProdukt telefon = null;

            switch (rodzajProducenta)
            {
                case Producent.Samsung:
                    telefon = new Samsung();
                    break;
                case Producent.Apple:
                    telefon = new Apple();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("rodzajProducenta", "Nieznany rodzaj producenta");
            }
            return telefon;

        }
    }

        class Fabryka
        {
            static void Main(string[] args)
            {
                IProdukt telefon = ProduktFactory.TworzenieObiektuTelefon(Producent.Apple);
                telefon.wyprodukujEkran();
                telefon.wyprodukujObudowe();

                IProdukt telefon2 = ProduktFactory.TworzenieObiektuTelefon(Producent.Samsung);
                telefon2.wyprodukujEkran();
                telefon2.wyprodukujObudowe();
                Console.ReadKey();
            }
        }
    }

