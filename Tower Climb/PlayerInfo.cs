using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterCreation;

namespace PlayerInfo
{
    internal class Player
    {
        public string name = "";
        public string gender = "";
        public DateTime dob;
        public int level;


        // stats
        public int hp = 10;
        public int fp = 10;
        public int patk = 3;
        public int pdef = 2;
        public int matk = 6;
        public int mdef = 4;
        public int spd = 3;
        public int luc = 1;

    }
}
