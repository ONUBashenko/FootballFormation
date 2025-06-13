using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FootballFormation.Classes.PositionInFormation;
using static FootballFormation.Classes.FormationHelper;

namespace FootballFormation.Classes
{
    public class FormationExtensions
    {
        public static Dictionary<PositionInFormation, bool> SetPositionsInFormation(FormationType formationName)
        {
            var PositionsInFormation = new Dictionary<PositionInFormation, bool>();

            PositionsInFormation[Goalkeeper] = true;
            SetDefenders(PositionsInFormation, formationName);
            SetMidfielders(PositionsInFormation, formationName);
            SetForwards(PositionsInFormation, formationName);

            return PositionsInFormation;
        }

        public static List<int> GetNumberOfPlayersInLine(FormationType formationName)
        {
            List<int> playersInLine = GetFormationString(formationName)
                .Split('-')
                .Select(int.Parse)
                .ToList();

            return playersInLine;
        }


        public static int HowManyDefenders(List<int> playersInLine)
        {
            return playersInLine.First();
        }
        public static int HowManyMidfielders(List<int> playersInLine)
        {
            return playersInLine[1];
        }
        public static int HowManyForwards(List<int> playersInLine)
        {
            return playersInLine.Last();
        }

        public static void SetDefenders(Dictionary<PositionInFormation, bool> PositionsInFormation, FormationType formationName)
        {
            int defendersCount = HowManyDefenders(GetNumberOfPlayersInLine(formationName));

            if (defendersCount == 3)
            {
                PositionsInFormation[CenterBackLeft] = true; //left
                PositionsInFormation[CenterBackCentral] = true; //central
                PositionsInFormation[CenterBackRight] = true; //right
            }
            else if (defendersCount == 4)
            {
                PositionsInFormation[LeftBack] = true;
                PositionsInFormation[CenterBackLeft] = true; //left
                PositionsInFormation[CenterBackRight] = true; //right
                PositionsInFormation[RightBack] = true;
            }
            else if (defendersCount == 5)
            {
                PositionsInFormation[LeftBack] = true;
                PositionsInFormation[CenterBackLeft] = true;
                PositionsInFormation[CenterBackCentral] = true;
                PositionsInFormation[CenterBackRight] = true;
                PositionsInFormation[RightBack] = true;
            }
        }

        public static void SetMidfielders(Dictionary<PositionInFormation, bool> PositionsInFormation, FormationType formationName)
        {
            int midfieldersCount = HowManyMidfielders(GetNumberOfPlayersInLine(formationName));

            if (midfieldersCount == 2)
            {
                PositionsInFormation[CenterMidfielderLeft] = true;
                PositionsInFormation[CenterMidfielderRight] = true;
            }
            else if (midfieldersCount == 3)
            {
                PositionsInFormation[CenterMidfielderLeft] = true; //left
                PositionsInFormation[CenterMidfielderCentral] = true; //central
                PositionsInFormation[CenterMidfielderRight] = true; //right
            }
            else if (midfieldersCount == 4)
            {
                PositionsInFormation[LeftMidfielder] = true;
                PositionsInFormation[CenterMidfielderLeft] = true; //left
                PositionsInFormation[CenterMidfielderRight] = true; //right
                PositionsInFormation[RightMidfielder] = true;
            }
            else if (midfieldersCount == 5)
            {
                PositionsInFormation[LeftMidfielder] = true;
                PositionsInFormation[CenterMidfielderLeft] = true; //left
                PositionsInFormation[CenterMidfielderRight] = true; //right
                PositionsInFormation[RightMidfielder] = true;
            }
        }

        public static void SetForwards(Dictionary<PositionInFormation, bool> PositionsInFormation, FormationType formationName)
        {
            int forwardsCount = HowManyForwards(GetNumberOfPlayersInLine(formationName));

            if (forwardsCount == 1)
            {
                PositionsInFormation[StrikerCentral] = true;
            }
            else if (forwardsCount == 2)
            {
                PositionsInFormation[StrikerLeft] = true; //left
                PositionsInFormation[StrikerRight] = true; //right
            }
            else if (forwardsCount == 3)
            {
                PositionsInFormation[LeftWinger] = true;
                PositionsInFormation[StrikerCentral] = true;
                PositionsInFormation[RightWinger] = true;
            }
            else if (forwardsCount == 4)
            {
                PositionsInFormation[LeftWinger] = true;
                PositionsInFormation[StrikerLeft] = true; //left
                PositionsInFormation[StrikerRight] = true; //right
                PositionsInFormation[RightWinger] = true;
            }
        }
    }
}
