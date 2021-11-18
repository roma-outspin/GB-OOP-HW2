using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGlib
{
    public interface IAttackable
    {
        public bool Attack(IDamagable enemy, Weapon weapon);
    }
}
