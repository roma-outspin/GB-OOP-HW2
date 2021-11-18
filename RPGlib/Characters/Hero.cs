using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGlib
{
    public abstract class Hero: IAttackable, IDamagable,IMovable
    {
        protected Hero(int health, int mana, int speed, string name, float damage)
        {
            Health = new Health(health);
            Mana = new Mana(mana);
            Speed = speed;
            Name = name;
            Damage = damage;
        }

        public Resource Health { get; set; }
        public Resource Mana { get; set; }
        public bool IsAlive { get; private set; }
        public int Speed { get; private set; }
        public string Name { get; private set; }
        public float Damage { get; private set; }
        public abstract List<Weapon> Inventory { get; set; }
        public int X { get; set; }
        public int Y { get; set ; }
        
        internal int GetDistanceFromEnemy(IDamagable enemy)
        {
            Point first = new Point(X, Y);
            Point second = new Point(enemy.X, enemy.Y);
            return first.Distance(second);
        }

        public virtual bool Attack(IDamagable enemy, Weapon weapon)
        {
            var DamageDistanceDecrease = GetDistanceFromEnemy(enemy);
            var attackDamage = Damage * (int)weapon.WeaponType - DamageDistanceDecrease;
            if(attackDamage>=0)
            {
                enemy.GetDamage(this, (int)attackDamage);
                return true;
            } else
            {
                return false;
            }
            
        }

        public void Dead()
        {
            Console.WriteLine($"Игрок {Name} убит");
            IsAlive = false;
        }

        public virtual void GetDamage(IDamagable enemy, int amount)
        {
            Health.Decrease(amount);
            if (Health.Level <= 0)
            {
                Dead();
            }     
        }

        public void Move(MoveDirectionsX directionX, MoveDirectionsY directionY)
        {
            X += (int)directionX;
            Y += (int)directionY;
        }
    }
}
