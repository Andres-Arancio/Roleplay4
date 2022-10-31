namespace RoleplayGame.Items
{
    /// <summary>
    /// Palo, permite atacar
    /// </summary>
    public class Palo : IAttackItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 10;
            }
        }

        public override string ToString()
        {
            return "Palo";
        }
    }
}