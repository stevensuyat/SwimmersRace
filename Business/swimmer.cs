using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwimmersRace.Business
{
    class Swimmer
    {
        public string Name { get; set; }

        //How far the swimmer has travelled?
        public int Length { get; set; }

        public PictureBox myPB { get; set; }
    }
}
