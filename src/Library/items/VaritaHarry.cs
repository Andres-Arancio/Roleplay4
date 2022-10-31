namespace RoleplayGame.Items
{
    /// <summary>
    /// VaritaHarry, permite atacar
    /// </summary>
    public class VaritaHarry : IAttackItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 30;
            }
        }

        public override string ToString()
        {
            return "VaritaHarry";
        }
    }
}