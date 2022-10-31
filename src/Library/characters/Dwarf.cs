using System.Collections.Generic;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Personaje Enano
    /// </summary>
    public class Dwarf : Character
    {
        public Dwarf(string name)
            : base(name)
        {
            this.Health = 150;
            ///this.AddItem(new Robes());
        }
    }
}