using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Items
{
    public class Pill : Bonus
    {
        private const int pillHealthEffect = 0;
        private const int pillDefenseEffect = 0;
        private const int pillAttackEffect = 100;
        private const int pillTimeout = 1;

        public Pill(string id)
            : base(id, pillHealthEffect, pillDefenseEffect, pillAttackEffect)
        {
            this.Countdown = pillTimeout;
            this.Timeout = pillTimeout;
            this.HasTimedOut = false;
        }
    }
}
