using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using FootballFormation;
using static FootballFormation.Player.PositionType;
using static FootballFormation.Formation;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("John Doe", 20, 190, GK, 20);
        Player player2 = new Player("Jane Smith", 28, 165, LB, 10);
        Player player3 = new Player("Alice Johnson", 22, 180, RB, 3);
        Player player4 = new Player("Bob Brown", 30, 189, CB, 12);
        Player player5 = new Player("Charlie White", 27, 180, CB, 7);
        Player player6 = new Player("David Green", 24, 180, LM, 30);
        Player player7 = new Player("Eve Black", 26, 180, RM, 10);
        Player player8 = new Player("Frank Blue", 29, 180, CM, 100);
        Player player9 = new Player("Grace Yellow", 23, 180, CM, 45);
        Player player10 = new Player("Hank Purple", 31, 165, ST, 34);
        Player player11 = new Player("Ivy Orange", 20, 160, ST, 50);

        Coach coach1 = new Coach("Coach Name", 80, 175, 15);
        coach1.AddFormation(FormationType.FourFourTwo);

        Team team1 = new Team("Team Name", "Ukraine", coach1);
        team1.AddPlayer(player); team1.AddPlayer(player2); team1.AddPlayer(player3); team1.AddPlayer(player4);
        team1.AddPlayer(player5); team1.AddPlayer(player6); team1.AddPlayer(player7); team1.AddPlayer(player8);
        team1.AddPlayer(player9); team1.AddPlayer(player10); team1.AddPlayer(player11);

        Formation formation1 = new Formation(FormationType.FourFourTwo);
        formation1.AddPlayerOnPosition(Formation.Goalkeeper, player); formation1.AddPlayerOnPosition(Formation.LeftBack, player2);
        formation1.AddPlayerOnPosition(Formation.RightBack, player3); formation1.AddPlayerOnPosition(Formation.CenterBackLeft, player4);
        formation1.AddPlayerOnPosition(Formation.CenterBackRight, player5); formation1.AddPlayerOnPosition(Formation.CenterMidfielderLeft, player6);
        formation1.AddPlayerOnPosition(Formation.CenterMidfielderRight, player7); formation1.AddPlayerOnPosition(Formation.LeftMidfielder, player8);
        formation1.AddPlayerOnPosition(Formation.RightMidfielder, player9); formation1.AddPlayerOnPosition(Formation.LeftStriker, player10);
        formation1.AddPlayerOnPosition(Formation.RightStriker, player11);

        ///
        ///
        ///
        Player player12 = new Player("John Doe", 25, 190, GK, 20);
        Player player13 = new Player("Jane Smith", 28, 165, LB, 10);
        Player player14 = new Player("Alice Johnson", 22, 180, RB, 3);
        Player player15 = new Player("Bob Brown", 30, 189, CB, 12);
        Player player16 = new Player("Charlie White", 27, 180, CB, 7);
        Player player17 = new Player("David Green", 24, 180, CM, 30);
        Player player18 = new Player("Eve Black", 26, 180, CM, 10);
        Player player19 = new Player("Frank Blue", 29, 180, CM, 100);
        Player player20 = new Player("Grace Yellow", 23, 180, LW, 45);
        Player player21 = new Player("Hank Purple", 31, 165, RW, 34);
        Player player22 = new Player("Ivy Orange", 20, 160, ST, 50);

        Coach coach2 = new Coach("Coach Name 2", 45, 180, 20);
        coach1.AddFormation(FormationType.FourThreeThree);
        Team team2 = new Team("Team Name 2", "Ukraine", coach2);

        Formation formation2 = new Formation(FormationType.FourThreeThree);
        formation2.AddPlayerOnPosition(Formation.Goalkeeper, player12); formation2.AddPlayerOnPosition(Formation.LeftBack, player13);
        formation2.AddPlayerOnPosition(Formation.RightBack, player14); formation2.AddPlayerOnPosition(Formation.CenterBackLeft, player15);
        formation2.AddPlayerOnPosition(Formation.CenterBackRight, player16); formation2.AddPlayerOnPosition(Formation.CenterMidfielderLeft, player17);
        formation2.AddPlayerOnPosition(Formation.CenterMidfielderRight, player18); formation2.AddPlayerOnPosition(Formation.CenterMidfielderCentral, player19);
        formation2.AddPlayerOnPosition(Formation.LeftWinger, player20); formation2.AddPlayerOnPosition(Formation.RightWinger, player21);
        formation2.AddPlayerOnPosition(Formation.Striker, player22);

        Match match = new Match(team1, team2, formation1, formation2);
        match.PrintMatchSummary();
    }
}
