using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startlist
{
    class Club
    {
        public string ClubName { get; set; }
        public List<Registration> RegisterList;
        public Club(string clubName)
        {
            RegisterList = new List<Registration>();
            ClubName = clubName;
        }
        public void Addparticipant(Registration participant)
        {
            RegisterList.Add(participant);
        }

        public void print()
        {
            Console.WriteLine();
            Console.WriteLine("ClubName: " + ClubName);
            Console.WriteLine();
            foreach (var registration in RegisterList)
            {
                registration.print();
            }
        }
    }
}
