using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGlib
{
    public class SharpShooter: Hero
    {
        //Снайпер обладает своим набором оружия и качествами, выгоднее атаковать с расстояния
        private const float _damage = 1.5f;
        private const int _speed = 20;
        private const int _health = 100;
        private const int _mana = 100;

        public SharpShooter(string name) : base(_health, _mana, _speed, name, _damage)
        {
            Inventory = new List<Weapon>();
            Inventory.Add(new Weapon(WeaponTypes.Knife, 10));
            Inventory.Add(new Weapon(WeaponTypes.Pistol, 20));
            Inventory.Add(new Weapon(WeaponTypes.Sniper, 50));
        }

        public override List<Weapon> Inventory { get; set; }
    }
}
