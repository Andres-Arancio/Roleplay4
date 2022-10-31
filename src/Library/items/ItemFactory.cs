namespace RoleplayGame.Items
{
    /// <summary>
    /// Tipos de elementos
    /// </summary>
    public enum ItemType
    {
        Magic = 1,
        Robes = 2,
        CopperShield = 3,
        Escarbadientes = 4,
        Zancos = 5,
        MataEnanos = 6,
        PowerGlove = 7,
        Palo=8,
        Coraza=9,
    }

    /// <summary>
    /// Creador de elementos. 
    /// </summary>
    public class ItemFactory
    {
        /// <summary>
        /// Permite crear elementos dado un tipo de elemento.
        /// </summary>
        /// <param name="type">El tipo de elemento</param>
        /// <returns>El elemento</returns>
        public static IItemPortable GetItem(ItemType type)
        {
            switch (type)
            {
                case ItemType.Magic: return new Magic();
                case ItemType.Robes: return new Robes();
                case ItemType.CopperShield: return new CopperShield();
                case ItemType.Coraza: return new Coraza();
                case ItemType.Escarbadientes: return new Escarbadientes();
                case ItemType.Zancos: return new Zancos();
                case ItemType.MataEnanos: return new MataEnanos();
                case ItemType.Palo: return new Palo();

                default: return null;
            }
        }
    }
}