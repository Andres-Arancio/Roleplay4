namespace RoleplayGame.Items
{
    /// <summary>
    /// Coraza, permite defender
    /// </summary>
    public class Coraza : IDefenseItem
    {
        /// <summary>
        /// El valor de defensa
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return 20;
            }
        }

        public override string ToString()
        {
            return "Coraza";
        }
    }
}