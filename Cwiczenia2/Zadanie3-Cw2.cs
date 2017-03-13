﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected string dataUrodzenia;

        public Osoba(string imie_, string nazwisko_, string dataUrodzenia_) { }
        public void WypiszInfo() { }
    }

    class Student : Osoba
    {
        Ocena ocena;
        private int rok;
        private int grupa;
        private int nrIndeksu;

        public Student(string imie_, string nazwisko_, string dataUrodzenia_, int rok, int grupa_, int nrIndeksu_) { }
        public void WypiszInfo() { }
        public void DodajOcene(string nazwaPrzedmiotu, string data, double wartosc) { }
        public void WypiszOceny() { }
        public void WypiszOceny(string nazwaPrzedmiotu) { }
        public void UsunOcene(string nazwaPrzedmiotu, string data, double wartosc) { }
        public void UsunOceny() { }
        public void UsunOceny(string nazwaPrzedmiotu) { }
    }

    class Pilkarz : Osoba
    {
        private string pozycja;
        private string klub;
        private int liczbaGoli = 0;

        public Pilkarz(string imie_, string nazwisko_, string dataUrodzenia_, string pozycja_, string klub_) { }
        public void WypiszInfo() { }
        public void StrzelGola() { }
    }

    class PilkarzReczny : Pilkarz
    {
        public PilkarzReczny(string imie_, string nazwisko_, string dataUrodzenia_, string pozycja_, string klub_) { }
        public void StrzelGola() { }
    }

    class PilkarzNozny : Pilkarz
    {
        public PilkarzNozny(string imie_, string nazwisko_, string dataUrodzenia_, string pozycja_, string klub_) { }
        public void StrzelGola() { }
    }

    class Ocena
    {
        private string nazwaPrzedmiotu;
        private string data;
        private double wartosc;

        public Ocena(string nazwaPrzedmiotu_, string data_, double wartosc_) { }
        public void WypiszInfo() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
