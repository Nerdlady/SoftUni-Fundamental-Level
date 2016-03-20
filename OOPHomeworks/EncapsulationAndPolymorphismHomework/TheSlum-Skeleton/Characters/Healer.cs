using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum.Characters
{
    public class Healer : Character, IHeal
    {
        private const int healingPoints = 60;
        private const int healthDefaultPoints = 75;
        private const int defenseDefaultPoints = 50;
        private const int defaultRange = 6;

        public Healer(string id, int x, int y, Team team)
            : base(id, x, y, healthDefaultPoints, defenseDefaultPoints, team, defaultRange)
        {
            this.HealingPoints = healingPoints;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var target = targetsList
                .Where(t => (t.Team == this.Team) && (t.Id != this.Id) && t.IsAlive)
                .OrderBy(t => t.HealthPoints)
                .First();
            return target;

        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.HealthPoints += item.HealthEffect;
            this.DefensePoints += item.DefenseEffect;
        }

        protected override void ApplyItemEffects(Item item)
        {
            this.HealthPoints += item.HealthEffect;
            this.DefensePoints += item.DefenseEffect;
        }

        public override void RemoveFromInventory(Item item)
        {
            throw new NotImplementedException();
        }


        public int HealingPoints { get; set; }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Healing: {0}", this.HealingPoints);
        }
    }
}
