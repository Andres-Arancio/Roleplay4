using System.Collections.Generic;
namespace RoleplayGame.Items
{
    /// <summary>
    /// Item compuesto por Escarbadientes y Zancos.
    /// </summary>
    public class PowerGlove : IAttackItem, IDefenseItem
    {
        private List<IGem> gemas {get;set;} = new List<IGem>();
        
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                int auxiliarAttack = 0;
                foreach(IGemAttack gemAttack in gemas)
                {
                    auxiliarAttack = auxiliarAttack + gemAttack.GemAttackPower;
                }
                return auxiliarAttack;
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
            int auxiliarDefense = 0;
                foreach(IGemDefense gemDefense in gemas)
                {
                    auxiliarDefense = auxiliarDefense + gemDefense.GemDefensePower;
                }
                return auxiliarDefense;
            }
        }

        public override string ToString()
        {
            return "Un guante que crece en poder mientras mas gemas se le agrega.";
        }
    }
}