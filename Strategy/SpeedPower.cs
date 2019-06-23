using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Game
{
    public class SpeedPower : ISuperPower
    {
        public SuperPower SuperPower { get; private set; }
        public SpeedPower()
        {
            SuperPower = new SuperPower(GetType().Name, Constants.SpeedPowerAttackPoints);
        }
        public SuperPower AttackWithSuperPower()
        {
            return SuperPower;
        }
    }
}
