using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGlib
{
    public class Weapon
    {
        public Weapon(WeaponTypes weaponType, int damage)
        {
            WeaponType = weaponType;
            Damage = damage;
            Distance = (int)WeaponType;
        }

        public WeaponTypes WeaponType { get; private set; }
        public int Damage { get; private set; }
        public int Distance { get; private set; }
    }
}
