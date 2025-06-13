using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballFormation.Classes
{
    public class Team
    {
        private string _name;
        private string _country;
        private Coach _teamCoach;
        private List<Player> _players;
        private static List<Team> teams = new List<Team>();

        public string Name
        {
            get {return _name;}
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Team name cannot be empty.");
                }
                _name = value;
            }
        }

        public string Country
        {
            get {return _country;}
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Country cannot be empty.");
                }
                _country = value;
            }
        }

        public Coach TeamCoach
        {
            get {return _teamCoach;}
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Coach cannot be null.");
                }
                if (value.Team != null)
                {
                    throw new ArgumentException("Coach is already assigned to another team.");
                }
                _teamCoach = value;
            }
        }

        public List<Player> Players
        {
            get {return _players;}
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Players list cannot be null.");
                }
                if (value.Count < 11 || value.Count > 25)
                {
                    throw new ArgumentException($"A team can have from 11 to 25 players (now {value.Count})");
                }
                foreach (var player in value)
                {
                    if (player.Team != null)
                    {
                        throw new ArgumentException($"Player {player.Name} is already assigned to another team.");
                    }
                }
                _players = value;
            }
        }

        public Team(string name, string country, Coach teamCoach, List<Player> players)
        {
            Name = name;
            Country = country;
            TeamCoach = teamCoach;
            Players = players;

            this.Assign();

            teams.Add(this);
        }

        private void Assign()
        {
            if (TeamCoach.Team != null)
                throw new InvalidOperationException("Coach already has a team.");

            foreach (var player in Players)
            {
                if (player.Team != null)
                    throw new InvalidOperationException($"Player {player.Name} already has a team.");
            }

            TeamCoach.Team = this;
            foreach (var player in Players)
            {
                player.Team = this;
            }
        }

        public override string ToString()
        {
            return Name;
        }

        public void Delete()
        {
            if (TeamCoach != null)
            {
                TeamCoach.Team = null;
            }
            foreach (var player in Players)
            {
                player.Team = null;
            }
            teams.Remove(this);
        }

        public static List<Team> GetAllTeams()
        {
            return teams;
        }
    }
}
