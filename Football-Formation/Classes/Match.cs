using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballFormation.Classes
{
    public class Match
    {
        private Team _homeTeam;
        private Team _awayTeam;
        private Formation _homeFormation;
        private Formation _awayFormation;
        private Dictionary<string, Tuple<int, int>> _matchEvents;
        private static List<Match> matches = new List<Match>();

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
                if (value == AwayTeam)
                {
                    throw new ArgumentException("Home team cannot be the same as away team.");
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
                if (value == HomeTeam)
                {
                    throw new ArgumentException("Away team cannot be the same as home team.");
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
            var summary = new Dictionary<string, Tuple<int, int>>();

            int homePossession = random.Next(30, 70);
            int awayPossession = 100 - homePossession;

            var homeShots = random.Next(0, 30);
            var awayShots = random.Next(0, 30);

            var homeShotsOnTarget = homeShots == 0 ? 0 : random.Next(homeShots / 4, homeShots + 1);
            var awayShotsOnTarget = awayShots == 0 ? 0 : random.Next(awayShots / 4, awayShots + 1);

            var homeGoals = random.Next(0, Math.Min(homeShotsOnTarget + 1, 6));
            var awayGoals = random.Next(0, Math.Min(awayShotsOnTarget + 1, 6));

            var homeCorners = random.Next(0, 10);
            var awayCorners = random.Next(0, 10);

            var homeFouls = random.Next(5, 25);
            var awayFouls = random.Next(5, 25);

            var homeYellows = random.Next(0, Math.Min(homeFouls / 2 + 1, 6));
            var awayYellows = random.Next(0, Math.Min(awayFouls / 2 + 1, 6));

            var homeReds = random.Next(0, homeYellows > 3 ? 2 : 1);
            var awayReds = random.Next(0, awayYellows > 3 ? 2 : 1);

            summary["Goals"] = Tuple.Create(homeGoals, awayGoals);
            summary["Possession"] = Tuple.Create(homePossession, awayPossession);
            summary["Shots"] = Tuple.Create(homeShots, awayShots);
            summary["Shots on target"] = Tuple.Create(homeShotsOnTarget, awayShotsOnTarget);
            summary["Corners"] = Tuple.Create(homeCorners, awayCorners);
            summary["Fouls"] = Tuple.Create(homeFouls, awayFouls);
            summary["Yellow cards"] = Tuple.Create(homeYellows, awayYellows);
            summary["Red cards"] = Tuple.Create(homeReds, awayReds);

            return summary;
        }

        public void Delete()
        {
            matches.Remove(this);
        }

        public static List<Match> GetAllMatches()
        {
            return matches;
        }
    }
}
