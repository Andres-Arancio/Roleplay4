namespace RoleplayGame.Items
{
    /// <summary>
    /// Gema del rayo.
    /// </summary>
    public class LightningGem : IGemAttack
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int GemAttackPower
        {
            get
            {
                return 10;
            }
        }
    }
}