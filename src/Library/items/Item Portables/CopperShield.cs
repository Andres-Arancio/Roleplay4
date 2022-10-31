namespace RoleplayGame.Items;

public class CopperShield : IDefenseItem
{
    public int DefensePower 
    {
        get
        {
            return 20;
        }
    }
    public override string ToString()
    {
        return "Escudo de Cobre";
    }
}