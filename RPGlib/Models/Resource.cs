using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGlib
{
    public abstract class Resource
    {
        internal int _maxLevel;

        public int Level { get; set; }
        public void Increase()
        {
            Increase(5);
        }
        public void Increase(int amount)
        {
            if (Level + amount > _maxLevel)
            {
                Level = _maxLevel;
            }
            else
            {
                Level += amount;
            }

        }
        public void Decrease(int amount)
        {
            if (Level - amount <= 0)
            {
                Level = 0;
            }
            else
            {
                Level -= amount;
            }
        }
    }
}
