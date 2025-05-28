using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static Football_Formation.Player.PositionType;
using static Football_Formation.PositionInFormation;

namespace Football_Formation
{
    public enum FormationType
    {
        //4-4-2
        FourFourTwo,
        //4-3-3
        FourThreeThree,
        //4-2-3-1
        FourTwoThreeOne,
        //3-5-2
        ThreeFiveTwo
    }
    public class Formation
    {
        // private List<Player> Players;
        private FormationType FormationName;
        private Dictionary<PositionInFormation, bool> PositionsInFormation;
        private Dictionary<PositionInFormation, Player> PlayersOnPositions;

        public static readonly List<PositionInFormation> AllExistingPositions = new List<PositionInFormation>
        {
            new PositionInFormation(GK),
            new PositionInFormation(LB),
            new PositionInFormation(RB),
            new PositionInFormation(CB, SpecificType.Left),
            new PositionInFormation(CB, SpecificType.Right),
            new PositionInFormation(CB, SpecificType.Central),
            new PositionInFormation(CM, SpecificType.Left),
            new PositionInFormation(CM, SpecificType.Right),
            new PositionInFormation(CM, SpecificType.Central),
            new PositionInFormation(CM, SpecificType.Attacking),
            new PositionInFormation(CM, SpecificType.Defensive),
            new PositionInFormation(LM),
            new PositionInFormation(RM),
            new PositionInFormation(LW),
            new PositionInFormation(RW),
            new PositionInFormation(ST, SpecificType.Left),
            new PositionInFormation(ST, SpecificType.Right),

        };

        public Formation(FormationType formationName)
        {
            FormationName = formationName;
            //PlayersOnPositions = SetPositionsInFormation(formationName);
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
