// See https://aka.ms/new-console-template for more information

using WeaponAttackSimulator.Weapons;
using WeaponAttackSimulator.Weapons.Factory;

WeaponFactory factory = new();
Weapon weapon = factory.GetWeapon("Pistol");
Weapon weapon2 = factory.GetWeapon("Pistol");

weapon.Attack("Player 1");
weapon2.Attack("Player 2");

Console.WriteLine($"Are both the same weapon: {weapon == weapon2}");