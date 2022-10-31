namespace RoleplayGame.Items
{
    /// <summary>
    /// Escarbadientes, permite atacar
    /// </summary>
    public class Escarbadientes : IAttackItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 100;
            }
        }

        public override string ToString()
        {
            return "Escarbadientes";
        }
    }
}