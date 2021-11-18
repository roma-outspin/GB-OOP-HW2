using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGlib
{
    //Волшебник в отличие от остальных героев при большом расстоянии телепортируется от атакующегои не получает урон 
    public class Wizard:Hero
    {
        private const float _damage = 1.5f;
        private const int _speed = 20;
        private const int _health = 100;
        private const int _mana = 100;
        public override List<Weapon> Inventory { get; set; }

        public Wizard(string name) : base(_health, _mana, _speed, name, _damage)
        {
            Inventory = new List<Weapon>();
            Inventory.Add(new Weapon(WeaponTypes.Knife, 30));
            Inventory.Add(new Weapon(WeaponTypes.Grenade, 70));
        }

        public override void GetDamage(IDamagable enemy, int amount)
        {
            var DamageDistanceDecrease = GetDistanceFromEnemy(enemy);
            if (DamageDistanceDecrease>5)
            {
                X += 2;
                Y += 2;
            } else
            {
                Health.Decrease(amount);
                if (Health.Level <= 0)
                {
                    Dead();
                }
            }
            
        }

        
    }
}
