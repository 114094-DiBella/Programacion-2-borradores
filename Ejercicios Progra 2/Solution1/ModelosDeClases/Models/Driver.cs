using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ModelosDeClases.Models
{
    public class Driver
    {
        

        public int DriverId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int TeamId { get; set; }
        public Team? Team { get; set; }

        [JsonConstructor]
        public Driver(int driverId, string firstName, string lastName, string nationality, DateTime dateOfBirth, int teamId, Team team)
        {
            DriverId = driverId;
            FirstName = firstName;
            LastName = lastName;
            Nationality = nationality;
            DateOfBirth = dateOfBirth;
            TeamId = teamId;
            Team = team;
        }

        public Driver()
        {
        }

        public Driver(Team? team)
        {
            this.Team = team;
        }
    }
}
