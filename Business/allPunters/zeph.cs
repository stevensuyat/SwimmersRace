using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmersRace.Business.allPunters
{
    public class Zeph : Punter
    {
        //this runs first
        public Zeph()
        {
            PunterName = "Zeph";
            Swimmer = "";
            Cash = 50;
        }

        public int Won { get; set; }
        public int Lost { get; set; }
        public int TotalBets()
        {
            return Won + Lost;
        }
    }
}
