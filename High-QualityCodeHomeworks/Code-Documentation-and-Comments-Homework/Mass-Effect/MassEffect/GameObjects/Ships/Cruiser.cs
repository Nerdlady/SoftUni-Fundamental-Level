﻿namespace MassEffect.GameObjects.Ships
{
    using MassEffect.GameObjects.Locations;
    using MassEffect.GameObjects.Projectiles;
    using MassEffect.Interfaces;

    public class Cruiser : Starship
    {
        // constructor
        public Cruiser(string name, StarSystem location)
            : base(name, 100, 100, 50, 300, location)
        {
        }

        // method
        public override IProjectile ProduceAttack()
        {
            return new PenetrationShell(this.Damage);
        }
    }
}