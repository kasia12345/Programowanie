using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontoBankowe
{
    public class KontoBankowe
    {
        public string _imieNazwisko;
        public int[] _numerKonta;
        private double _fundusze;
        private int _idKonta;

        public KontoBankowe()
        {
            this._imieNazwisko = "TEST";
            this._numerKonta = null;
            this._fundusze = 0;
            this._idKonta = 0;

        }
        public KontoBankowe(string imieNazwisko, double fundusze)
        {
            this._imieNazwisko = imieNazwisko;
            this._numerKonta = GenerujNrKonta();
            this._fundusze = fundusze;
            this._idKonta = GenerujIdKonta();
        }
        public KontoBankowe(string imieNazwisko)
        {
            this._imieNazwisko = imieNazwisko;
            this._numerKonta = GenerujNrKonta();
            this._idKonta = GenerujIdKonta();
            this._fundusze = 0;
        }

        public void WplacPieniadze(double ilosc)
        {
            this._fundusze += ilosc;
        }
        public void WyplacPieniadze(double ilosc)
        {
           // if (ilosc <= _fundusze)
                this._fundusze -= ilosc;
            //else
             //   Console.WriteLine("Brak funduszy, możesz wypłacić maksymalnie {0:C2}", Convert.ToDecimal(_fundusze));
        }
        public double StanKonta
        {
            get { return _fundusze; }
            //Console.WriteLine("Stan konta {0:C2}", Convert.ToDecimal(_fundusze));
        }
        private int[] GenerujNrKonta()
        {
            int[] nrKonta = new int[26];
            Random r = new Random();
            for (int i = 0; i < nrKonta.Length; i++)
                nrKonta[i] = r.Next(0, 10);
            return nrKonta;
        }

        private int GenerujIdKonta()
        {
            int idKonta;
            Random r = new Random();
            idKonta = r.Next(100000, 99999999);
            return idKonta;
        }
        public void TransferPieniedzy(KontoBankowe A, KontoBankowe B, double ilosc)
        {
            B._fundusze += ilosc;
            A._fundusze -= ilosc;

        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            KontoBankowe A = new KontoBankowe("Jan Kowalski", 1200);
            KontoBankowe B = new KontoBankowe("Anna Nowak", 800);

            A.WplacPieniadze(150.0);
            A.WyplacPieniadze(100.0);
            A.TransferPieniedzy(A,B,200.0);



            Console.ReadKey();
        }
    }
}
