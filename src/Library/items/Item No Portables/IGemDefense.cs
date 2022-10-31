namespace RoleplayGame.Items
{
    /// <summary>
    /// Interfaz que permite crear gemas de ataque.
    /// </summary>
    public interface IGemDefense: IGem
    {
        int GemDefensePower{ get; }
    }
}