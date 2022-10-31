namespace RoleplayGame.Items
{
    /// <summary>
    /// Interfaz que permite crear gemas de ataque.
    /// </summary>
    public interface IGemAttack: IGem
    {
        int GemAttackPower{ get; }
    }
}