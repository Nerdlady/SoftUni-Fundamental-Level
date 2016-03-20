namespace MassEffect.GameObjects.Projectiles
{
    using MassEffect.Interfaces;

    public abstract class Projectile : IProjectile
    {
        // constructor
        protected Projectile(int damage)
        {
            this.Damage = damage;
        }

        // property
        public int Damage { get; set; }

        // method
        public abstract void Hit(IStarship targetShip);
    }
}