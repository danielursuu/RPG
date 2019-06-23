namespace RPG_Game
{
    public class MagicPower : ISuperPower
    {
        public SuperPower SuperPower { get; private set; }

        public MagicPower()
        {
            SuperPower = new SuperPower(GetType().Name, Constants.MagicPowerAttackPoints);
        }
        public SuperPower AttackWithSuperPower()
        {
            return SuperPower;
        }
    }
}
