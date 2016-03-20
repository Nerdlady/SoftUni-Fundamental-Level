using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum.Characters
{
    public class Warrior : Character, IAttack
    {
        private int attackPoints = 150;
        private const int healthDefaultPoints = 200;
        private const int defenseDefaultPoints = 100;
        private const int defaultRange = 2;

        public  Warrior(string id, int x, int y, Team team)
            : base(id, x, y, healthDefaultPoints, defenseDefaultPoints, team, defaultRange)
        {
            this.AttackPoints = attackPoints;
        }

        public int AttackPoints { get; set; }


        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var target = targetsList.FirstOrDefault(t => (t.Team != this.Team) && (t.Id != this.Id) && t.IsAlive);
            return target;
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            this.RemoveItemEffects(item);
        }

        protected override void ApplyItemEffects(Item item)
        {
            this.AttackPoints += item.AttackEffect;
            base.ApplyItemEffects(item);
        }

        protected override void RemoveItemEffects(Item item)
        {
            this.AttackPoints -= item.AttackEffect;
            base.RemoveItemEffects(item);
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Attack: {0}", this.AttackPoints);
        }
    }
}
