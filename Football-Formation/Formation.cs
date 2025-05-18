using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Football_Formation.Player.PositionType;

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
        // private List<Player> Players;
        private FormationType FormationName;
        private SortedDictionary<Player.PositionType, bool> PositionsInFormation;
        private SortedDictionary<Player.PositionType, Player> PlayersOnPositions;

        public Formation(FormationType formationName)
        {
            FormationName = formationName;
        }
        public void SetGoalkeeper(Player player)
        {
            if (PositionsInFormation[Goalkeeper] == true)
            {
                PlayersOnPositions.Add(Goalkeeper, player);
                PositionsInFormation[Goalkeeper] = false;
            }
            else
            {
                throw new Exception("Position is already occupied");
            }
        }
        public void SetDefender(Player player)
        {
            if (PositionsInFormation[Defender] == true)
            {
                PlayersOnPositions.Add(Defender, player);
                PositionsInFormation[Defender] = false;
            }
            else
            {
                throw new Exception("Position is already occupied");
            }
        }
        public void SetMidfilder(Player player)
        {
            if (PositionsInFormation[Midfielder] == true)
            {
                PlayersOnPositions.Add(Midfielder, player);
                PositionsInFormation[Midfielder] = false;
            }
            else
            {
                throw new Exception("Position is already occupied");
            }
        }
        public void SetForward(Player player)
        {
            if (PositionsInFormation[Forward] == true)
            {
                PlayersOnPositions.Add(Forward, player);
                PositionsInFormation[Forward] = false;
            }
            else
            {
                throw new Exception("Position is already occupied");
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Formation: {FormationName}");
            sb.AppendLine("Players in formation:");
            foreach (var position in PlayersOnPositions)
            {
                sb.AppendLine($"{position.Key}: {position.Value}");
            }
            return sb.ToString();
        }
    }
}
