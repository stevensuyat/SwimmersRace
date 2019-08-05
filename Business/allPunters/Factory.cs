using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmersRace.Business.allPunters
{
    class Factory
    {
        //Descides which class we want to instantiate
        //1,2,3
        public static Punter GetAPunter(int id)
        {
            switch (id)
            {
                case 0:
                    return new Zeph();
                case 1:
                    return new Sarah();
                case 2:
                    return new Mae();
                case 3:
                    return new Fey();

                default: return null;

            }

        }
    }
}
