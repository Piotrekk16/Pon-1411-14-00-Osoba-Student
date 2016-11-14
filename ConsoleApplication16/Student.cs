using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Student:Osoba
    {
        private int rokStudiow;
        private int numerGrupy;
        private int numerAlbumu;

        public Student() { }

        public Student(string imie, string nazwisko, int rokStudiow, int numerGrupy, int numerAlbumu)
            :base(imie,nazwisko)
        {
            this.rokStudiow = rokStudiow;
            this.numerGrupy = numerGrupy;
            this.numerAlbumu = numerAlbumu;
        }

        public override void WyswietlInfo()
        {
            base.WyswietlInfo();
            Console.WriteLine("rok studiów: {0}",rokStudiow);
            Console.WriteLine("numer grupy: {0}", numerGrupy);
            Console.WriteLine("numer albumu: {0}", numerAlbumu);
        }
    }
}
