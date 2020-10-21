using System;

namespace Tutorial
{
    class Program
    {
        // https://www.youtube.com/watch?v=ju4ofJUuEX4&ab_channel=DavidTielke
        static void Main(string[] args)
        {
            var p = new Person()
            {
                Vornamen = "David",
                Nachname = "Tielke"
            };

            Console.WriteLine(p[1]);
        }
    }

    class Person
    {
        public string Vornamen { get; set; }
        public string Nachname { get; set; }

        public string VollerName2 => Vornamen + " " + Nachname;

        public string VollerName
        {
            get
            {
                return Vornamen + " " + Nachname;
            }
        }

        public char this[int index] => VollerName[index];

        /*
        public char this[int index]
        {
            get
            {
                return VollerName[index];
            }
        }
        */

        /*
        public void Heirate(Person partner)
        {
            this.Nachname = partner.Nachname;
        }
        */

        public void Heirate(Person person) => this.Nachname = person.Nachname;

        public int Add(int z1, int z2) => z1 + z2;
    }
}
