using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Items
{
    public class Injection : Bonus
    {
        private const int injectionHealthEffect = 200;
        private const int injectionDefenseEffect = 0;
        private const int injectionAttackEffect = 0;
        private const int injectionTimeout = 3;

        public Injection(string id)
            : base(id, injectionHealthEffect, injectionDefenseEffect, injectionAttackEffect)
        {
            this.Countdown = injectionTimeout;
            this.Timeout = injectionTimeout;
            this.HasTimedOut = false;
        }
    }
}
