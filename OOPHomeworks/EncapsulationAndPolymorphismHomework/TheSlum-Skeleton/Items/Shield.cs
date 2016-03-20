using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Items
{
    class Shield : Item
    {
        private const int healthEffect = 0;
        private const int defenseEffect = 50;
        private const int attackEffect = 0;
        public Shield(string id)
            : base(id, healthEffect ,defenseEffect, attackEffect)
        {

        }
    }
}
