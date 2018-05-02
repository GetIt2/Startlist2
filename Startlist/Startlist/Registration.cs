using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startlist
{
    class Registration
    {
        public string Startnumber { get; set; }
        public string Name { get; set; }
        public string Club { get; set; }
        public string Nationality { get; set; }
        public string Group { get; set; }
        public string Class { get; set; }
         
        public Registration(string[] parts)
        {
            Startnumber = parts[0];
            Name = parts[1];
            Club = parts[2];
            Nationality = parts[3];
            Group = parts[4];
            Class = parts[5];
        }

        public void print()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("StartNumber: " + Startnumber);
            Console.WriteLine("Club: " + Club);
            Console.WriteLine("Nationality: " + Nationality);
            Console.WriteLine("Group: " + Group);
            Console.WriteLine("Class: " + Class);
            Console.WriteLine();
        }
    }
}
