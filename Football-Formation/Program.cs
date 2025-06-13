using FootballFormation.Classes;
using System;
using System.Drawing;
using System.Security.Policy;
using System.Windows.Forms;
using static FootballFormation.Classes.FormationType;
using static FootballFormation.Classes.PositionInFormation;
using static FootballFormation.Classes.PositionType;

namespace FootballFormation
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // First team setup
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

            Coach coach1 = new Coach("Hans-Dieter «Hansi» Flick", 60, 177, 30, [FourThreeThree, ThreeFourThree]);

            var Team1Players = new List<Player>
            {
                player, player2, player3, player4, player5, player6, player7, player8, player9, player10, player11
            };
            Team team1 = new Team("FC Barcelona", "Spain", coach1, Team1Players);

            var playersOnPositions1 = new Dictionary<PositionInFormation, Player>
            {
                { Goalkeeper, player },
                { LeftBack, player2 },
                { RightBack, player3 },
                { CenterBackLeft, player4 },
                { CenterBackRight, player5 },
                { CenterMidfielderLeft, player6 },
                { CenterMidfielderCentral, player7 },
                { CenterMidfielderRight, player8 },
                { LeftWinger, player9 },
                { RightWinger, player10 },
                { StrikerCentral, player11 }
            };

            Formation formation1 = new Formation(FourThreeThree, playersOnPositions1);

            // Second team setup
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

            Coach coach2 = new Coach("Xabi Alonso", 43, 183, 7, [FourThreeThree, FiveTwoThree]);

            var Team2Players = new List<Player>
            {
                player12, player13, player14, player15, player16, player17, player18, player19, player20, player21, player22
            };
            Team team2 = new Team("Real Madrid", "Spain", coach2, Team2Players);

            var playersOnPositions2 = new Dictionary<PositionInFormation, Player>
            {
                { Goalkeeper, player12 },
                { LeftBack, player13 },
                { RightBack, player14 },
                { CenterBackLeft, player15 },
                { CenterBackRight, player16 },
                { CenterMidfielderLeft, player17 },
                { CenterMidfielderRight, player18 },
                { CenterMidfielderCentral, player19 },
                { LeftWinger, player20 },
                { RightWinger, player21 },
                { StrikerCentral, player22 }
            };

            Formation formation2 = new Formation(FourThreeThree, playersOnPositions2);

            Match match = new Match(team1, team2, formation1, formation2);

            // Additional setup for the match
            new Player("Alisson Becker", 32, 193, GK, 90);
            new Player("Manuel Neuer", 39, 193, GK, 100);
            new Player("Gianluigi Donnarumma", 26, 196, GK, 110);
            new Player("Federico Dimarco", 27, 175, LB, 120);
            new Player("Trent Alexander-Arnold", 26, 175, RB, 130);
            new Player("Alejandro Grimaldo", 27, 171, LB, 190);
            new Player("Achraf Hakimi", 26, 181, RB, 200);
            new Player("Nico Schlotterbeck", 25, 191, CB, 140);
            new Player("Virgil van Dijk", 33, 195, CB, 150);
            new Player("Illya Zabarnyi", 22, 189, CB, 230);
            new Player("Ruben Dias", 28, 186, CB, 240);
            new Player("Joshua Kimmich", 30, 176, CM, 160);
            new Player("Stanislav Lobotka", 30, 170, CM, 170);
            new Player("N'Golo Kante", 34, 168, CM, 180);
            new Player("Hakan Çalhanoğlu", 31, 178, CM, 210);
            new Player("Kevin De Bruyne", 33, 181, CM, 40);
            new Player("Paulo Dybala", 31, 177, CM, 250);
            new Player("Neymar da Silva Santos Júnior", 33, 175, LW, 30);
            new Player("Rafael Leão", 26, 188, LW, 200);
            new Player("Khvicha Kvaratskhelia", 24, 183, LW, 220);
            new Player("Cristiano Ronaldo", 40, 189, ST, 20);
            new Player("Erling Braut Haaland", 24, 194, ST, 80);
            new Player("Mohamed Salah", 32, 175, RW, 70);
            new Player("Lionel Messi", 37, 169, RW, 10);

            new Coach("Josep «Pep» Guardiola", 54, 180, 15, [FourFourTwo, FiveTwoThree, FiveFourOne, FourTwoFour]);

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}
