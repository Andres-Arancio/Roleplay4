namespace RoleplayGame.Items
{
    /// <summary>
    /// Interfaz que permite crear elementos de ataque.
    /// </summary>
    public interface IAttackItem: IItemPortable
    {
        int AttackPower{ get; }
    }
}