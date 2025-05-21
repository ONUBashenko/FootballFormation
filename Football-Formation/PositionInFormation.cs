using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Formation
{
    public class PositionInFormation
    {
        public enum SpecificType
        {
            left,
            right,
            central,
            attacking,
            defensive
        }

        private Player.PositionType _positionName;
        private SpecificType _positionSpecific;
        private Player _playerOnPosition;

        public Player.PositionType PositionName
        {
            get {return _positionName;}
            set 
            {
                _positionName = value;
            }
        }
        public SpecificType PositionSpecific
        {
            get {return _positionSpecific;}
            set 
            {
                _positionSpecific = value;
            }
        }
        public Player PlayerOnPosition
        {
            get {return _playerOnPosition;}
            set
            {
                if (PositionSpecific == SpecificType.right || PositionSpecific == SpecificType.left || PositionSpecific == SpecificType.central)
                {
                    //if(value.MainPosition == Player.PositionType.Defender || value.MainPosition == Player.PositionType.Midfielder)
                    _playerOnPosition = value;
                }
                else if (PositionSpecific == SpecificType.attacking || PositionSpecific == SpecificType.defensive)
                { 
                    //if(value.MainPosition == Player.PositionType.Midfielder)
                    _playerOnPosition = value;
                }
                else
                    _playerOnPosition = value;
            }
        }

        public PositionInFormation(Player.PositionType positionName, SpecificType specific, Player playerOnPosition)
        {
            PositionName = positionName;
            PositionSpecific = specific;
            PlayerOnPosition = playerOnPosition;
        }


    }
}
