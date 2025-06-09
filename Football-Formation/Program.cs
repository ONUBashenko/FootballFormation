using System;
using System.Windows.Forms;
using static FootballFormation.Classes.Player.PositionType;
using FootballFormation.Classes;

namespace FootballFormation
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Player player = new Player("Marc-Andre ter Stegen", 33, 187, GK, 25);
            Player player2 = new Player("Alejandro Balde", 21, 175, LB, 45);
            Player player3 = new Player("Jules Kounde", 26, 178, RB, 70);
            Player player4 = new Player("Pau Cubarsí", 18, 184, CB, 60);
            Player player5 = new Player("Inigo Martínez", 34, 182, CB, 10);
            Player player6 = new Player("Frenkie de Jong ", 28, 181, CM, 70);
            Player player7 = new Player("Pedri", 22, 174, CM, 100);
            Player player8 = new Player("Gavi", 20, 173, CM, 55);
            Player player9 = new Player("Raphinha", 28, 176, LW, 80);
            Player player10 = new Player("Lamine Yamal", 17, 180, RW, 120);
            Player player11 = new Player("Robert Lewandowski", 36, 185, ST, 15);

            Coach coach1 = new Coach("Hans-Dieter «Hansi» Flick", 60, 177, 30);
            coach1.AddFormation(FormationType.FourThreeThree);
            coach1.AddFormation(FormationType.ThreeFourThree);

            Team team1 = new Team("FC Barcelona", "Spain", coach1);
            team1.AddPlayer(player); team1.AddPlayer(player2); team1.AddPlayer(player3); team1.AddPlayer(player4);
            team1.AddPlayer(player5); team1.AddPlayer(player6); team1.AddPlayer(player7); team1.AddPlayer(player8);
            team1.AddPlayer(player9); team1.AddPlayer(player10); team1.AddPlayer(player11);

            var playersOnPositions1 = new Dictionary<PositionInFormation, Player>
            {
                { Formation.Goalkeeper, player },
                { Formation.LeftBack, player2 },
                { Formation.RightBack, player3 },
                { Formation.CenterBackLeft, player4 },
                { Formation.CenterBackRight, player5 },
                { Formation.CenterMidfielderLeft, player6 },
                { Formation.CenterMidfielderCentral, player7 },
                { Formation.CenterMidfielderRight, player8 },
                { Formation.LeftWinger, player9 },
                { Formation.RightWinger, player10 },
                { Formation.StrikerCentral, player11 }
            };

            Formation formation1 = new Formation(FormationType.FourThreeThree, playersOnPositions1);


            ///
            ///
            ///
            Player player12 = new Player("Thibaut Courtois", 33, 200, GK, 20);
            Player player13 = new Player("Ferland Mendy", 29, 180, LB, 10);
            Player player14 = new Player("Dani Carvajal", 33, 173, RB, 20);
            Player player15 = new Player("Eder Militao", 27, 186, CB, 35);
            Player player16 = new Player("Antonio Rudiger ", 32, 190, CB, 45);
            Player player17 = new Player("Jude Bellingham", 21, 186, CM, 140);
            Player player18 = new Player("Federico Valverde", 26, 182, CM, 130);
            Player player19 = new Player("Luka Modrić", 39, 172, CM, 1);
            Player player20 = new Player("Vinícius Júnior", 24, 176, LW, 100);
            Player player21 = new Player("Rodrygo", 24, 174, RW, 75);
            Player player22 = new Player("Kylian Mbappe", 26, 178, ST, 150);

            Coach coach2 = new Coach("Xabi Alonso", 43, 183, 7);
            coach2.AddFormation(FormationType.FourThreeThree);
            coach2.AddFormation(FormationType.FiveTwoThree);
            Team team2 = new Team("Real Madrid", "Spain", coach2);

            team2.AddPlayer(player12); team2.AddPlayer(player13); team2.AddPlayer(player14); team2.AddPlayer(player15);
            team2.AddPlayer(player16); team2.AddPlayer(player17); team2.AddPlayer(player18); team2.AddPlayer(player19);
            team2.AddPlayer(player20); team2.AddPlayer(player21); team2.AddPlayer(player22);

            var playersOnPositions2 = new Dictionary<PositionInFormation, Player>
            {
                { Formation.Goalkeeper, player12 },
                { Formation.LeftBack, player13 },
                { Formation.RightBack, player14 },
                { Formation.CenterBackLeft, player15 },
                { Formation.CenterBackRight, player16 },
                { Formation.CenterMidfielderLeft, player17 },
                { Formation.CenterMidfielderRight, player18 },
                { Formation.CenterMidfielderCentral, player19 },
                { Formation.LeftWinger, player20 },
                { Formation.RightWinger, player21 },
                { Formation.StrikerCentral, player22 }
            };

            Formation formation2 = new Formation(FormationType.FourThreeThree, playersOnPositions2);

            Match match = new Match(team1, team2, formation1, formation2);

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}
