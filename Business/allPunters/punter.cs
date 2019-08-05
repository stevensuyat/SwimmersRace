using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwimmersRace.Business.allPunters
{
    public class Punter
    {
        public string PunterName { get; set; }
        public string Swimmer { get; set; }
        public Single Cash { get; set; }
        public Single Bet { get; set; }
        public Label labelWinner { get; set; }
    }
}
