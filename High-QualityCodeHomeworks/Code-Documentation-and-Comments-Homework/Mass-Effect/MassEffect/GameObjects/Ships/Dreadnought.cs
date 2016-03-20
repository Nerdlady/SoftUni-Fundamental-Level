﻿namespace MassEffect.GameObjects.Ships
{
    using MassEffect.GameObjects.Locations;
    using MassEffect.GameObjects.Projectiles;
    using MassEffect.Interfaces;

    public class Dreadnought : Starship
    {
        // constructor
        public Dreadnought(string name, StarSystem location)
            : base(name, 200, 300, 150, 700, location)
        {
        }

        // methods
        public override IProjectile ProduceAttack()
        {
            var damageCoefficient = (this.Shields / 2) + this.Damage;

            return new Laser(damageCoefficient);
        }

        public override void RespondToAttack(IProjectile attack)
        {
            this.Shields += 50;

            base.RespondToAttack(attack);

            this.Shields -= 50;
        }
    }
}