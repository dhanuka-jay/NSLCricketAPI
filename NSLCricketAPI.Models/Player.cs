using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSLCricketAPI.Models
{
    public class Player
    {
        public int ID { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public DateTime joinedOn { get; set; }
        public PlayerRoles role { get; set; }
    }
}
