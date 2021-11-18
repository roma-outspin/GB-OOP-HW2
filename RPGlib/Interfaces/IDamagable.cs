using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGlib
{
    public interface IDamagable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Resource Health { get; set; }
        public void GetDamage(IDamagable enemy, int amount);
        public void Dead();
    }
}
