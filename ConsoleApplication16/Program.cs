using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba1 = new Osoba("Jan", "Kowalski");
            Student student1 = new Student("Anna", "Nowak", 2, 3, 11234);
            osoba1.WyswietlInfo();
            student1.WyswietlInfo();
            Osoba student2 = new Student("Tomasz","Nowak",1,2,34111);
            student2.WyswietlInfo();


            Console.ReadKey();
        }
    }
}
