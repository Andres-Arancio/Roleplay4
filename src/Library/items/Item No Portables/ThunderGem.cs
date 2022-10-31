namespace RoleplayGame.Items
{
    /// <summary>
    /// Gema del trueno.
    /// </summary>
    public class ThunderGem : IGemDefense
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int GemDefensePower
        {
            get
            {
                return 10;
            }
        }
    }
}