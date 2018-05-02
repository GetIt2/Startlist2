using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startlist
{
    class Program
    {
        public static List<Club> ClubList;
        static void Main(string[] args)
        {
            ClubList = new List<Club>();
            foreach (var line in File.ReadLines("startlist.csv"))
            {
                var parts = line.Split(',');
                var participant = new Registration(parts);
                var club = FindMatchingClub(participant) ?? CreateNewClub(participant); 
                club.Addparticipant(participant); 
            }

            foreach (var club in ClubList)
            {
                club.print();
            }
        }

        private static Club FindMatchingClub(Registration participant)
        {
            foreach (var club in ClubList)
            {
                if (participant.Club == club.ClubName)
                {
                    return club;
                }
            }
            return null;
        }

        private static Club CreateNewClub(Registration participant)
        {
            var club = new Club(participant.Club);
            ClubList.Add(club);
            return club;
        }
    }
}
