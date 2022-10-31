namespace RoleplayGame.Items
{
    /// <summary>
    /// Item compuesto por Escarbadientes y Zancos.
    /// </summary>
    public class MataEnanos : IAttackItem, IDefenseItem
    {
        private Escarbadientes palito {get;set;} = new Escarbadientes();
        private Zancos zancos {get;set;} = new Zancos();
        
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return zancos.AttackPower+palito.AttackPower;
            }
        }

        /// <summary>
        /// El poder de defensa
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return zancos.DefensePower;
            }
        }

        public override string ToString()
        {
            return "La Maxima Arma Contra Enanos";
        }
    }
}