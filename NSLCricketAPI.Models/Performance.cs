using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSLCricketAPI.Models
{
    public class Performance
    {
        public int Id { get; set; }
        public DateTime GameDay { get; set; }
        public int Runs { get; set; }
        public float Overs { get; set; }
        public int Wickets { get; set; }
        public int PlayerId { get; set; }
        public Player Player { get; set; }
    }
}
