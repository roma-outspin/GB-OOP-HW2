﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGlib
{
    public class Health : Resource
    {
        public Health(int maxlevel)
        {
            _maxLevel = maxlevel;
            Level = _maxLevel;
        }
    }
}