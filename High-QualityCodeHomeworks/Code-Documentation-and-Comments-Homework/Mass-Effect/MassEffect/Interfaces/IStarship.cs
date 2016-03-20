namespace MassEffect.Interfaces
{
    using MassEffect.GameObjects.Locations;
    
    /// <summary>
    /// The starship interface
    /// </summary>
    public interface IStarship : IEnhanceable
    {
        /// <summary>
        /// Gets or set the name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Ship health.
        /// </summary>
        int Health { get; set; }

        /// <summary>
        /// Gets or set the shields.
        /// </summary>
        int Shields { get; set; }

        /// <summary>
        /// Gets or set the damage.
        /// </summary>
        int Damage { get; set; }

        /// <summary>
        /// Gets or set the fuel.
        /// </summary>
        double Fuel { get; set; }

        /// <summary>
        /// Gets or set the location.
        /// </summary>
        StarSystem Location { get; set; }

        /// <summary>
        /// The produce the attack.
        /// </summary>
        /// <returns></returns>
        IProjectile ProduceAttack();

        /// <summary>
        /// The respond to attack.
        /// </summary>
        /// <param name="attack">The attack</param>
        void RespondToAttack(IProjectile attack);
    }
}