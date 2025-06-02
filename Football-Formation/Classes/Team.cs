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
        private List<Player> _players;
        private Coach _teamCoach;

        public string Name
        {
            get {return _name;}
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Team name cannot be null or empty.");
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
                    throw new ArgumentException("Country cannot be null or empty.");
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
                _players = value;
            }
        }

        public Team(string name, string country, Coach teamCoach)
        {
            Name = name;
            Country = country;
            TeamCoach = teamCoach;
            Players = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            if (player == null)
            {
                throw new ArgumentNullException("Player cannot be null.");
            }
            _players.Add(player);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Team Name: {Name}, Country: {Country}");
            sb.AppendLine($"Coach: {TeamCoach.Name}, Experience: {TeamCoach.Experience} years");
            sb.AppendLine("Players:");
            foreach (var player in Players)
            {
                sb.AppendLine(player.ToString());
            }
            return sb.ToString();
        }
    }
}
