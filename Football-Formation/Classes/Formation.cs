using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static FootballFormation.Classes.Player;
using static FootballFormation.Classes.Player.PositionType;
using static FootballFormation.Classes.PositionInFormation;
using static FootballFormation.Classes.FormationExtensions;
using static FootballFormation.Classes.FormationHelper;

namespace FootballFormation.Classes
{
    public enum FormationType
    {
        //3-4-3
        ThreeFourThree,
        //3-5-2
        ThreeFiveTwo,
        //4-2-4
        FourTwoFour,
        //4-3-3
        FourThreeThree,
        //4-4-2
        FourFourTwo,
        //4-5-1
        FourFiveOne,
        //5-2-3
        FiveTwoThree,
        //5-3-2
        FiveThreeTwo,
        //5-4-1
        FiveFourOne
    }
    public class Formation
    {
        private FormationType _formationName;
        private Dictionary<PositionInFormation, bool> _positionsInFormation;
        private Dictionary<PositionInFormation, Player> _playersOnPositions;

        public FormationType FormationName
        {
            get {return _formationName;}
            set
            {
                if (!Enum.IsDefined(typeof(FormationType), value))
                {
                    throw new ArgumentException("Invalid formation type.");
                }
                _formationName = value;
            }
        }

        public Dictionary<PositionInFormation, bool> PositionsInFormation
        {
            get {return _positionsInFormation;}
            set
            {
                if (value == null || value.Count == 0)
                {
                    throw new ArgumentException("Positions in formation cannot be null or empty.");
                }
                _positionsInFormation = value;
            }
        }

        public Dictionary<PositionInFormation, Player> PlayersOnPositions
        {
            get {return _playersOnPositions;}
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Players on positions cannot be null.");
                }
                _playersOnPositions = value;
            }
        }

        public static readonly PositionInFormation Goalkeeper = new PositionInFormation(GK);
        public static readonly PositionInFormation LeftBack = new PositionInFormation(LB);
        public static readonly PositionInFormation RightBack = new PositionInFormation(RB);
        public static readonly PositionInFormation CenterBackLeft = new PositionInFormation(CB, SpecificType.Left);
        public static readonly PositionInFormation CenterBackRight = new PositionInFormation(CB, SpecificType.Right);
        public static readonly PositionInFormation CenterBackCentral = new PositionInFormation(CB, SpecificType.Central);
        public static readonly PositionInFormation CenterMidfielderLeft = new PositionInFormation(CM, SpecificType.Left);
        public static readonly PositionInFormation CenterMidfielderRight = new PositionInFormation(CM, SpecificType.Right);
        public static readonly PositionInFormation CenterMidfielderCentral = new PositionInFormation(CM, SpecificType.Central);

        /* public static readonly PositionInFormation CentralDefensiveMidfielderLeft = new PositionInFormation(CDM, SpecificType.Left);
        public static readonly PositionInFormation CentralDefensiveMidfielderRight = new PositionInFormation(CDM, SpecificType.Right);
        public static readonly PositionInFormation CentralDefensiveMidfielder = new PositionInFormation(CDM);
        public static readonly PositionInFormation CentralAttackingMidfielderLeft = new PositionInFormation(CAM, SpecificType.Left);
        public static readonly PositionInFormation CentralAttackingMidfielderRight = new PositionInFormation(CAM, SpecificType.Right);
        public static readonly PositionInFormation CentralAttackingMidfielderCentral = new PositionInFormation(CAM, SpecificType.Central); */

        public static readonly PositionInFormation LeftMidfielder = new PositionInFormation(LM);
        public static readonly PositionInFormation RightMidfielder = new PositionInFormation(RM);
        public static readonly PositionInFormation LeftWinger = new PositionInFormation(LW);
        public static readonly PositionInFormation RightWinger = new PositionInFormation(RW);
        public static readonly PositionInFormation StrikerLeft = new PositionInFormation(ST, SpecificType.Left);
        public static readonly PositionInFormation StrikerRight = new PositionInFormation(ST, SpecificType.Right);
        public static readonly PositionInFormation StrikerCentral = new PositionInFormation(ST);

        public static readonly List<PositionInFormation> AllExistingPositions = new List<PositionInFormation>
        {
            Goalkeeper,

            //Defenders
            LeftBack,
            RightBack,
            CenterBackLeft,
            CenterBackRight,
            CenterBackCentral,

            //Midfielders
            CenterMidfielderLeft,
            CenterMidfielderRight,
            CenterMidfielderCentral,
            LeftMidfielder,
            RightMidfielder,

            //Forwards
            LeftWinger,
            RightWinger,
            StrikerLeft,
            StrikerRight,
            StrikerCentral,
        };


        public Formation(FormationType formationName, Dictionary<PositionInFormation, Player> playersOnPositions)
        {
            FormationName = formationName;
            PositionsInFormation = SetPositionsInFormation(formationName);
            PlayersOnPositions = playersOnPositions;
        }

        public void AddPlayerOnPosition(PositionInFormation position, Player player)
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

        public void RemovePlayerFromPosition(PositionInFormation position)
        {
            if (!PositionsInFormation.ContainsKey(position))
            {
                throw new ArgumentException("There is no such position in this formation type.");
            }
            if (PlayersOnPositions.ContainsKey(position))
            {
                PlayersOnPositions.Remove(position);
            }
            else
            {
                throw new ArgumentException("No player assigned to this position.");
            }
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
            sb.AppendLine($"Formation: {GetFormationString(FormationName)}");
            sb.AppendLine("Players in formation:");
            foreach (var position in PlayersOnPositions)
            {
                sb.AppendLine($"{position.Key}: {position.Value}");
            }
            return sb.ToString();
        }
    }
}
