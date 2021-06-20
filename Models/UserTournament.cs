using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace F1_App.Models
{
    public class UserTournament
    {
        public int Id { get; set; }
        public int TournamentId { get; set; }
        public string UserId { get; set; }
        public UserTournament()
        {

        }
    }
}
