namespace WeaponAttackSimulator.Weapons
{
    public class Weapon
    {
        private string _name;

        public Weapon(string name)
        {
            _name = name;
        }

        public void Attack(string player)
        {
            Console.WriteLine($"{player} uses {_name} to attack");
        }
    }
}
