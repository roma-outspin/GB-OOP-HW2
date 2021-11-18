using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGlib
{
    //Воин обладает своим набором оружия и качествами
    public class Warrior : Hero
    {
        private const float _damage = 1.1f;
        private const int _speed = 50;
        private const int _health = 100;
        private const int _mana = 100;

        public Warrior(string name) : base(_health, _mana, _speed, name, _damage)
        {
            Inventory = new List<Weapon>();
            Inventory.Add(new Weapon(WeaponTypes.Knife, 10));
            Inventory.Add(new Weapon(WeaponTypes.Pistol, 20));
            Inventory.Add(new Weapon(WeaponTypes.Rifle, 30));
        }

        public override List<Weapon> Inventory { get ; set ; }
    }
}
