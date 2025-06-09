using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FootballFormation.Classes.FormationHelper;

namespace FootballFormation.Classes
{
    public class Match
    {
        private Team _homeTeam;
        private Team _awayTeam;
        private Formation _homeFormation;
        private Formation _awayFormation;
        private Dictionary<string, Tuple<int, int>> _matchEvents;
        public static List<Match> matches = new List<Match>();

        Random random = new Random();

        public Team HomeTeam
        {
            get { return _homeTeam; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Home team cannot be null.");
                }
                _homeTeam = value;
            }
        }

        public Team AwayTeam
        {
            get { return _awayTeam; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Away team cannot be null.");
                }
                _awayTeam = value;
            }
        }

        public Formation HomeFormation
        {
            get { return _homeFormation; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Home formation cannot be null.");
                }
                _homeFormation = value;
            }
        }

        public Formation AwayFormation
        {
            get { return _awayFormation; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Away formation cannot be null.");
                }
                _awayFormation = value;
            }
        }

        public Dictionary<string, Tuple<int, int>> MatchEvents
        {
            get { return _matchEvents; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Match events cannot be null.");
                }
                _matchEvents = value;
            }
        }
        public Match(Team homeTeam, Team awayTeam, Formation homeFormation, Formation awayFormation)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            HomeFormation = homeFormation;
            AwayFormation = awayFormation;
            MatchEvents = GetMatchSummary();

            matches.Add(this);
        }


        public Dictionary<string, Tuple<int, int>> GetMatchSummary()
        {
            var MatchSummary = new Dictionary<string, Tuple<int, int>>
            {
                { "Goals", Tuple.Create(random.Next(0, 10), random.Next(0, 10)) },
                { "Shots", Tuple.Create(random.Next(0, 10), random.Next(0, 10)) },
                { "Shots on target", Tuple.Create(random.Next(0, 10), random.Next(0, 10)) },
                { "Corners", Tuple.Create(random.Next(0, 10), random.Next(0, 10)) },
                { "Fouls", Tuple.Create(random.Next(0, 10), random.Next(0, 10)) },
                { "Yellow cards", Tuple.Create(random.Next(0, 10), random.Next(0, 10)) },
                { "Red cards", Tuple.Create(random.Next(0, 10), random.Next(0, 10)) }
            };

            return MatchSummary;
        }
    }
}
