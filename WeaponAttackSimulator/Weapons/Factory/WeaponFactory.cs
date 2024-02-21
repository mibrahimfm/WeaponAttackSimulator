namespace WeaponAttackSimulator.Weapons.Factory
{
    public class WeaponFactory
    {
        private Dictionary<string, Weapon> weapons = new();

        public Weapon GetWeapon(string name)
        {
            if (!weapons.ContainsKey(name))
                weapons[name] = new Weapon(name);    
            return weapons[name];           
        }
    }
}
