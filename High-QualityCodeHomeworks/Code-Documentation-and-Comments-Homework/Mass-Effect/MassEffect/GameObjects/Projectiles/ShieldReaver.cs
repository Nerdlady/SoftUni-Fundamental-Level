namespace MassEffect.GameObjects.Projectiles
{
    using MassEffect.Interfaces;

    public class ShieldReaver : Projectile
    {
        // constructor
        public ShieldReaver(int damage)
            : base(damage)
        {
        }

        // method
        public override void Hit(IStarship targetShip)
        {
            targetShip.Shields -= this.Damage * 2;
            targetShip.Health -= this.Damage;
        }
    }
}