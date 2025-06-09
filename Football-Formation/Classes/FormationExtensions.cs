using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FootballFormation.Classes.Formation;
using static FootballFormation.Classes.FormationHelper;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            if (HowManyDefenders(GetNumberOfPlayersInLine(formationName)) == 3)
            {
                PositionsInFormation[CenterBackLeft] = true; //left
                PositionsInFormation[CenterBackCentral] = true; //central
                PositionsInFormation[CenterBackRight] = true; //right
            }
            else if (HowManyDefenders(GetNumberOfPlayersInLine(formationName)) == 4)
            {
                PositionsInFormation[LeftBack] = true;
                PositionsInFormation[CenterBackLeft] = true; //left
                PositionsInFormation[CenterBackRight] = true; //right
                PositionsInFormation[RightBack] = true;
            }
            else if (HowManyDefenders(GetNumberOfPlayersInLine(formationName)) == 5)
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
            if (HowManyMidfielders(GetNumberOfPlayersInLine(formationName)) == 2)
            {
                PositionsInFormation[CenterMidfielderLeft] = true;
                PositionsInFormation[CenterMidfielderRight] = true;
            }
            else if (HowManyMidfielders(GetNumberOfPlayersInLine(formationName)) == 3)
            {
                PositionsInFormation[CenterMidfielderLeft] = true; //left
                PositionsInFormation[CenterMidfielderCentral] = true; //central
                PositionsInFormation[CenterMidfielderRight] = true; //right
            }
            else if (HowManyMidfielders(GetNumberOfPlayersInLine(formationName)) == 4)
            {
                PositionsInFormation[LeftMidfielder] = true;
                PositionsInFormation[CenterMidfielderLeft] = true; //left
                PositionsInFormation[CenterMidfielderRight] = true; //right
                PositionsInFormation[RightMidfielder] = true;
            }
            else if (HowManyMidfielders(GetNumberOfPlayersInLine(formationName)) == 5)
            {
                PositionsInFormation[LeftMidfielder] = true;
                PositionsInFormation[CenterMidfielderLeft] = true; //left
                PositionsInFormation[CenterMidfielderRight] = true; //right
                PositionsInFormation[RightMidfielder] = true;
            }
        }

        public static void SetForwards(Dictionary<PositionInFormation, bool> PositionsInFormation, FormationType formationName)
        {
            if (HowManyForwards(GetNumberOfPlayersInLine(formationName)) == 1)
            {
                PositionsInFormation[StrikerCentral] = true;
            }
            else if (HowManyForwards(GetNumberOfPlayersInLine(formationName)) == 2)
            {
                PositionsInFormation[StrikerLeft] = true; //left
                PositionsInFormation[StrikerRight] = true; //right
            }
            else if (HowManyForwards(GetNumberOfPlayersInLine(formationName)) == 3)
            {
                PositionsInFormation[LeftWinger] = true;
                PositionsInFormation[StrikerCentral] = true;
                PositionsInFormation[RightWinger] = true;
            }
            else if (HowManyForwards(GetNumberOfPlayersInLine(formationName)) == 4)
            {
                PositionsInFormation[LeftWinger] = true;
                PositionsInFormation[StrikerLeft] = true; //left
                PositionsInFormation[StrikerRight] = true; //right
                PositionsInFormation[RightWinger] = true;
            }
        }
    }
}
