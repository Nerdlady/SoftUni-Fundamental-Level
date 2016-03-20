using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TheSlum.Items
{
    public class Axe : Item
    {
        private const int healthEffect = 0;
        private const int defenseEffect = 0;
        private const int attackEffect = 75;
        public Axe(string id)
            : base(id, healthEffect, defenseEffect,  attackEffect)
        {

        }
    }
}
