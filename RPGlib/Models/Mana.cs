using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGlib
{
    public class Mana: Resource
    {
        public Mana(int maxlevel)
        {
            _maxLevel = maxlevel;
            Level = _maxLevel;
        }
    }
}
