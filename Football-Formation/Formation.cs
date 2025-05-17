using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Formation
{
    public enum FormationType
    {
        //4-4-2
        FourFourTwo,
        //4-3-3
        FourThreeThree,
        //4-2-3-1
        FourTwoThreeOne
    }
    public class Formation
    {
        private List<Player> Players;
        private FormationType FormationName;

        public Formation(FormationType formationName)
        {
            Players = new List<Player>();
            FormationName = formationName;
        }
    }
}
