using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static FootballFormation.Classes.PositionType;
using static FootballFormation.Classes.PositionInFormation;
using static FootballFormation.Classes.FormationExtensions;

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
            get { return _playersOnPositions; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Players on positions cannot be null.");
                }
                if (value.Count != 11)
                {
                    throw new ArgumentException("There must be exactly 11 players in formation.");
                }
                foreach (var position in value.Keys)
                {
                    if (!PositionsInFormation.ContainsKey(position))
                    {
                        throw new ArgumentException($"Position {position} does not exist in this formation.");
                    }
                }
                _playersOnPositions = value;
            }
        }

        public Formation(FormationType formationName, Dictionary<PositionInFormation, Player> playersOnPositions)
        {
            FormationName = formationName;
            PositionsInFormation = SetPositionsInFormation(formationName);
            PlayersOnPositions = playersOnPositions;
        }
    }
}
