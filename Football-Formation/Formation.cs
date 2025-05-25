using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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
        private Dictionary<PositionInFormation, bool> PositionsInFormation;
        private Dictionary<PositionInFormation, Player> PlayersOnPositions;

        public Formation(FormationType formationName)
        {
            FormationName = formationName;
        }

        public void AddInformation(PositionInFormation position, Player player)
        {
            if (!PositionsInFormation.ContainsKey(position))
            {
                throw new ArgumentException("There is no such position in this formation type.");
            }
            if (PlayersOnPositions.ContainsKey(position))
            {
                throw new ArgumentException("Player already assigned to this position.");
            }
            PlayersOnPositions.Add(position, player);
        }

        public void ChangePlayerOnPosition(PositionInFormation position, Player player)
        {
            if (!PositionsInFormation.ContainsKey(position))
            {
                throw new ArgumentException("There is no such position in this formation type.");
            }
            if (PlayersOnPositions.ContainsKey(position))
            {
                PlayersOnPositions[position] = player;
            }
            else
            {
                throw new ArgumentException("No player assigned to this position.");
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
