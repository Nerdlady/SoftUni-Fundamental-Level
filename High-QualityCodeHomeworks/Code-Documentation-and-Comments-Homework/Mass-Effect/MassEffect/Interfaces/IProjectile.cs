namespace MassEffect.Interfaces
{
    /// <summary>
    /// The projectile interface.
    /// </summary>
    public interface IProjectile
    {
        /// <summary>
        /// Gets or set the damage.
        /// </summary>
        int Damage { get; set; }

        /// <summary>
        /// The hit.
        /// </summary>
        /// <param name="ship">The ship.</param>
        void Hit(IStarship ship);
    }
}